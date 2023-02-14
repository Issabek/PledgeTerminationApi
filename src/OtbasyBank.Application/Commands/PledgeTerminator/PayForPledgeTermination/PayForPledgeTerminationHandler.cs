using MediatR;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtbasyBank.Application.Helpers;
using OtbasyBank.Shared.Helpers;
using System.Globalization;
using Newtonsoft.Json;

namespace OtbasyBank.Application.Commands.PledgeTerminator.PayForPledgeTermination
{
    public class PayForPledgeTerminationHandler : IRequestHandler<PayForPledgeTerminationCommand, GenericReply<PledgeTerminateModel>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        private readonly ISignService _signService;
        private readonly IBusService _busService;
        private readonly ILocalizationService _localizationService;
        public PayForPledgeTerminationHandler(IPledgeTerminatorService pledgeTerminatorService, ILocalizationService localizationService, ISignService signService, IBusService busService)
        {
            _pledgeTerminatorService = pledgeTerminatorService;
            _localizationService = localizationService;
            _signService = signService;
            _busService = busService;
        }

        public async Task<GenericReply<PledgeTerminateModel>> Handle(PayForPledgeTerminationCommand request, CancellationToken cancellationToken)
        {
            GenericReply<PledgeTerminateModel> reply = new();
            try
            {
                Domain.Entities.Client client = await _pledgeTerminatorService.GetClientByIIN(request.IIN);
                var model = await GetPledgeTerminateModel(request.AppId);
                var payResponse = await _pledgeTerminatorService.PayForPledgeTermination(model, client.ClientCode);
                if (payResponse.Item1 != null && payResponse.Item2 != null)
                {
                    model.data.TransactionNumber = payResponse.Item1.ToString();
                    model.data.TransactionDate = DateTime.Now;
                    var payRecordResponse = await PrepareAndCallBlockchainPayRecord(model, client, request.UserName);
                    if (string.IsNullOrEmpty(payRecordResponse.ErrorText))
                    {
                        model.PledgeResponse = await _pledgeTerminatorService.GetBlockchainInfo(request.AppId);

                        if (model.PledgeResponse.status == "REGISTERED")
                        {
                            SaveBlockchainDocument(model.PledgeResponse, request.Lang, model.data.LoanId, client);
                            reply.Add(model);
                        }
                        reply.AddError(new Domain.Common.ErrorMessage(Guid.NewGuid().ToString(), model.PledgeResponse.status, "200", "Error in PayForPledgeTerminationHandler", model.PledgeResponse.suspend.finalOpinionRu[0]));

                    }
                    else
                    {
                        reply.AddError(new Domain.Common.ErrorMessage(Guid.NewGuid().ToString(), "ERROR", "404", "Error in PrepareAndCallBlockchainRecord", payRecordResponse.ErrorText));
                    }
                }
                else
                {
                    reply.AddError(new Domain.Common.ErrorMessage(Guid.NewGuid().ToString(), "ERROR", "404", "Error in PayForPledgeTermination", null));
                }
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;

        }

        private async Task<PledgeTerminateModel> GetPledgeTerminateModel(string appId)
        {
            var model = new PledgeTerminateModel();
            _pledgeTerminatorService.GetLetterInfo(ref model, appId);
            return model;

        }
        private async Task<PledgeContract> PrepareAndCallBlockchainPayRecord(PledgeTerminateModel model, Domain.Entities.Client client, string userName)
        {
            var html = HtmlPrint.GetRequisite(model.PledgeResponse.paymentData, DateTime.Now.ToString("dd.MM.yyyy"))
                .Replace("{Квитанция}", Localize("Квитанция", true))
                .Replace("{сумма}", Localize("сумма", true))
                .Replace("{комиссия}", Localize("комиссия", true))
                .Replace("{назначение_платежа}", Localize("назначение_платежа", true))
                .Replace("{кнп}", Localize("кнп", true))
                .Replace("{Код_получателя}", Localize("Код_получателя", true))
                .Replace("{Получатель_платежа}", Localize("Получатель_платежа", true))
                .Replace("{Номер_счета_получателя}", Localize("Номер_счета_получателя", true))
                .Replace("{Квитанция_оплачена}", Localize("Квитанция_оплачена", true))
                .Replace("{Плательщик}", Localize("Плательщик", true))
                .Replace("{ао_жилстройсбербанк_казахстана}", Localize("ао_жилстройсбербанк_казахстана", true))
                .Replace("{TransactionNumber}", GetTransactionNumber(model.data.TransactionNumber))
                .Replace("{RequisiteNumber}", model.data.TransactionNumber)
                .Replace("{подпись}", Localize("подпись", true))
                .Replace("{Транзации}", Localize("транзации", true))
                .Replace("{otpSignature}", Localize("подписано_клиентом_с_помощью_OTP_с_номера", true));

            byte[] bytes = PdfConverter.HtmlToPdf(html);
            string hash = Hash.CreateSha1Hash(bytes);
            string ecpSign = _signService.SignDoc(hash);

            var payment = new Payment[]
            {
                    new Payment
                    {
                        amount = Convert.ToDecimal(model.PledgeResponse.paymentData.amountPay, new CultureInfo("en-US")),
                        bankName = "АО Отбасы банк",
                        bik = "HCSKKZKA",
                        callCenter = "",
                        numberBankTransaction = model.data.TransactionNumber,
                        numberCard = "",
                        payCode = model.data.TransactionNumber,
                        payDate = model.data.TransactionDate.ToString("s"),
                        payerIdn = "030740001404",
                        payDocHash = hash
                    }
            };

            var body = new PledgePayment
            {
                AppId = model.data.AppId,
                payment = payment
            };

            var signs = new PledgeSignatures
            {
                pledgers = new string[] { ecpSign }
            };
            PledgeContract pledgeContract = JsonConvert.DeserializeObject<PledgeContract>(_busService.PayedBlockchainRecord(body, signs, hash, Convert.ToBase64String(bytes)));

            string fileName = "Квитанция оплаты.pdf";
            var userFileType = await _pledgeTerminatorService.GetUserFileType(OtbasyBank.Shared.Enums.UserFileTypes.PLEDGE_TERMINATE_REQUISITE);
            userFileType.FileTypeName = fileName;

            var getFile = await _pledgeTerminatorService.GetUserFile((int)client.UserId, Shared.Enums.UserFileTypes.PLEDGE_TERMINATE_NOTIFICATION, model.data.AppId);
            _pledgeTerminatorService.SaveServiceFileQueue(Shared.Enums.MethodTypes.UploadFileToCredit, client.ClientCode, model.data.LoanId, bytes, (int)userFileType.BankFileTypeId, fileName, userName);
            _pledgeTerminatorService.SaveServiceFileQueue(Shared.Enums.MethodTypes.UploadFileToCredit, client.ClientCode, model.data.LoanId, PdfConverter.HtmlToPdf(System.Text.Encoding.UTF8.GetString(getFile.FileData)), (int)getFile.BankFileId, getFile.FileName, userName);
            return pledgeContract;

        }
        private string Localize(string word, bool isRus)
        {
            return _localizationService.GetCulturedLocalizedString(word, isRus);
        }
        public static string GetTransactionNumber(string transactionNumber)
        {
            return @"<tr>
                        <td class='gtxt'>{Транзации}</td>
                        <td><p class='btxt'>" + transactionNumber + @"</p></td>
                    </tr>";
        }
        public async Task<bool> SaveBlockchainDocument(BlockchainGetTerminatePledgeResponse pledgeResponse, string lang, string loandId, Domain.Entities.Client client)
        {
            if (pledgeResponse.notification == null)
                return false;
            var content = _busService.GetBlockchainDocument<string>(pledgeResponse.notification.notificationHash[lang.Equals("ru-RU") ? 1 : 0]);
            string fileName = lang.Equals("ru-RU") ? pledgeResponse.notification.finalOpinionKz[0] : pledgeResponse.notification.finalOpinionRu[0] + ".pdf";
            var userFileType = await _pledgeTerminatorService.GetUserFileType(OtbasyBank.Shared.Enums.UserFileTypes.NOTIFICATION_OF_THE_COMPLETED_STATE_REGISTRATION);
            _pledgeTerminatorService.SaveGeneratedPDF(content, Shared.Enums.UserFileTypes.NOTIFICATION_OF_THE_COMPLETED_STATE_REGISTRATION, userFileType, client, fileName, pledgeResponse.AppId);
            return true;

        }
    }
}
