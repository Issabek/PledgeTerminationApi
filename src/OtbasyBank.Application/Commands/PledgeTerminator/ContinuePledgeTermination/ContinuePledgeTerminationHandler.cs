using MediatR;
using OtbasyBank.Application.Helpers;
using OtbasyBank.Application.Interfaces;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Commands.PledgeTerminator.ContinuePledgeTerminationCommand
{
    public class ContinuePledgeTerminationHandler : IRequestHandler<ContinuePledgeTerminationCommand, GenericReply<string>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        private readonly IBusService _busService;
        private readonly ISignService _signService;
        public ContinuePledgeTerminationHandler(IPledgeTerminatorService pledgeTerminatorService, IBusService busService, ISignService signService )
        {
            _pledgeTerminatorService = pledgeTerminatorService;
            _busService = busService;
            _signService = signService;
        }
        public async Task<GenericReply<string>> Handle(ContinuePledgeTerminationCommand request, CancellationToken cancellationToken)
        {
            GenericReply<string> reply = new();
            try
            {
                Domain.Entities.Client client = await _pledgeTerminatorService.GetClientByIIN(request.Iin);
                var model = await GetPledgeTerminateModel(request.AppId);
                var fileBytes = await CreateNotificationPdf(model, client, request.Lang);
                var ecpSign = await SignDoc(fileBytes);
                var data = new BlockchainCreateDataModel
                {
                    AppId = model.data.AppId,
                    RKA = model.data.Rka,
                    pledgeeIds = new string[] { "030740001404" },
                    pledgerIds = model.data.TaxCodes.ToArray(),
                    payerIdn = "030740001404",
                    documentHash = Hash.CreateSha1Hash(fileBytes),
                    documentInfo = new DocumentInfo
                    {
                        docDate = model.data.OperDate.ToString("dd.MM.yyyy"),
                        docNumber = model.data.RegNum,
                        docType = "3444"
                    },
                    pledgeInfo = new PledgeInfo[]
                    {
                    new PledgeInfo
                    {
                        docDate=model.data.DocDate,
                        docNumber = model.data.DocNumber
                    }
                    },
                    attachments = new Attachments[] { }
                };
                var signs = new PledgeSignatures
                {
                    pledgees = new string[] { ecpSign },
                    pledgers = null
                };
                var result = _busService.CreateBlockchainRecord(data, signs, data.documentHash, Convert.ToBase64String(fileBytes));
                reply.Add(result);
            }
            catch(Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;
        }

        private async Task<byte[]> CreateNotificationPdf(PledgeTerminateModel model,Domain.Entities.Client client, string lang)
        {
            model.data.OperDate = _busService.GetCurrentOperDay();
            var pdfFile = lang == "ru-RU" ? HtmlPrint.GetLetterEncumbrances(model) : HtmlPrint.GetLetterEncumbrancesKz(model);
            string fileName = "Уведомление о снятии обременения.pdf";

            //получение UserFileType
            var userFileType = await _pledgeTerminatorService.GetUserFileType(OtbasyBank.Shared.Enums.UserFileTypes.PLEDGE_TERMINATE_NOTIFICATION);
            userFileType.FileTypeName = fileName;
            //сохранение и получение файла
            var file = await _pledgeTerminatorService.SaveGeneratedPDF(pdfFile, Shared.Enums.UserFileTypes.PLEDGE_TERMINATE_NOTIFICATION, userFileType, client, fileName,model.data.AppId);
            if (file == null)
                throw new NullReferenceException(nameof(file));
            return file;
        }

        private async Task<PledgeTerminateModel> GetPledgeTerminateModel(string appId)
        {
            var model = new PledgeTerminateModel();
             _pledgeTerminatorService.GetLetterInfo( ref model,appId);
            return model;

        }

        public async Task<string> SignDoc(byte[] pdfFile)
        {
            var docHash = Hash.CreateSha1Hash(pdfFile);
            return _signService.SignDoc(docHash);
        }
    }
}
