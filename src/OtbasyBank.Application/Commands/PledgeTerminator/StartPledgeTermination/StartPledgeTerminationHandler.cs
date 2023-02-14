using MediatR;
using Newtonsoft.Json;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Commands.PledgeTerminator.StartPledgeTermination
{
    public class StartPledgeTerminationHandler : IRequestHandler<StartPledgeTerminationCommand, GenericReply<string>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        private readonly IBusService _busService;
        public StartPledgeTerminationHandler(IPledgeTerminatorService pledgeTerminatorService, IBusService busService)
        {
            _pledgeTerminatorService = pledgeTerminatorService;
            _busService = busService;
        }
        public async Task<GenericReply<string>> Handle(StartPledgeTerminationCommand request, CancellationToken cancellationToken)
        {

            GenericReply<string> reply = new();
            try
            {
                string appId = AppIdGenerator(request.SysUserName);
                var user = await _pledgeTerminatorService.GetClientByIIN(request.ClientIIN);
                var letterModel = new LetterEncumbrancesModel(await _pledgeTerminatorService.GetLetterEncumbrances(request.LoanId));
                //var pledgeTerminateModel = await PledgeTerminateModelInit(letterModel, request.LoanId, request.ClientIIN, (int)user.UserId, request.RKA);
                var isDone = await _pledgeTerminatorService.StartPledgeTermination(appId, request.LoanId, JsonConvert.SerializeObject(letterModel), request.RKA);
                if (isDone)
                {
                    reply.Add(appId);
                    return reply;
                }
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;

        }
        //private async Task<PledgeTerminateModel> PledgeTerminateModelInit(LetterEncumbrancesModel model, string loanId, string clientIIN, int userId, string RKA)
        //{
        //    PledgeTerminateModel pledgeTerminateModel = new PledgeTerminateModel();
        //    PledgeTerminateLetterModel data = new PledgeTerminateLetterModel();
        //    data.LnCode = model.LnCode;
        //    data.DateBegin = model.DateBegin;
        //    data.CliLongName = model.CliLongName;
        //    data.FltAddress = model.FltAddress;
        //    data.DclCode = model.DclCode;
        //    data.EnsCode = model.EnsCode;
        //    data.DocNumber = model.DocNumber;
        //    data.DocDate = model.DocDate;
        //    data.PledgeDocNumber = model.PledgeDocNumber;
        //    data.PledgeDocDate = model.PledgeDocDate;
        //    data.TaxCodes = model.TaxCodes;
        //    data.CliCodes = model.CliCodes;
        //    data.CliNames = model.CliNames;
        //    data.UserId = userId;
        //    data.LoanId = loanId;
        //    data.Rka = RKA;
        //    data.RegNum = _busService.GetZayavaRegNum(clientIIN, "Уведомление о снятии обременения");
        //    pledgeTerminateModel.data = data;
        //    return pledgeTerminateModel;
        //}

        private string AppIdGenerator(string userName)
        {
            DateTime curDatimeTime = DateTime.Now;
            string tail = curDatimeTime.ToString("yyyy") + curDatimeTime.ToString("MM") + curDatimeTime.ToString("dd") + curDatimeTime.ToString("ss") + curDatimeTime.ToString("fff");
            switch (userName)
            {
                case "BPMUser":
                    tail = "INPT" + tail;
                    break;
                case "GlobalUser":
                    tail = "OUTPT" + tail;
                    break;
                default:
                    tail = "NANPT" + tail;
                    break;

            }
            return tail;
        }
    }
}
