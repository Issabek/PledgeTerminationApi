using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OtbasyBank.Api.Models.Replies;
using OtbasyBank.Application.Queries;
//using OtbasyBank.Application.Commands;
using OtbasyBank.Api.Models.ApiResponseModels.PledgeTerminator;
using OtbasyBank.Application.Queries.PledgeTerminator.GetUserFileById;
using System.Reflection;
using OtbasyBank.Application.Queries.PledgeTerminator.GetLetterEncumbrances;
using OtbasyBank.Application.Queries.PledgeTerminator.CanBeTerminated;
using OtbasyBank.Application.Queries.PledgeTerminator.GetBlockchainInfo;
using OtbasyBank.Application.Commands.PledgeTerminator.StartPledgeTermination;
using OtbasyBank.Api.Models.ApiRequestModels.PledgeTerminator;
using OtbasyBank.Application.Commands.PledgeTerminator.ContinuePledgeTerminationCommand;
using OtbasyBank.Application.Commands.PledgeTerminator.PayForPledgeTermination;

namespace OtbasyBank.Api.Controllers
{
    [ApiController]
    [Route("api/application")]
    public class PledgeTerminatorApiController : BaseController
    {
        private readonly ILogger<PledgeTerminatorApiController> _logger;


        public PledgeTerminatorApiController(ILogger<PledgeTerminatorApiController> logger)
        {
            _logger = logger;
        }
        private void LogMethod()
        {
            _logger.LogInformation("User {0} is calling method {1}", User.Identity.Name ?? "Unauthorized", System.Reflection.MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().GetParameters());
        }

        [HttpGet("get-test")]
        public async Task<IActionResult> test()
        {
            return Ok("TEST FOR NONAUTHORIZED");
        }
        [HttpGet("get-test-auth")]
        [Authorize]
        public async Task<IActionResult> testAuth()
        {
            return Ok("TEST FOR AUTHORIZED");
        }

        [HttpGet("get-user-file-by-id")]
        [Authorize]
        public async Task<IActionResult> GetUserFile(long fileId)
        {

            LogMethod();
            var query = new GetUserFileByIdQuery(fileId);
            var terminatorReply = await Mediator.Send(query);
            return Ok(terminatorReply);
        }

        [HttpGet("can-be-terminated")]
        [Authorize]
        public async Task<IActionResult> CanBeTerminated(string loanId)
        {
            LogMethod();
            var query = new CanBeTerminatedQuery(loanId);
            var terminatorReply = await Mediator.Send(query);
            return Ok(terminatorReply);
        }

        [HttpGet("get-letter-encumbrances")]
        [Authorize]
        public async Task<IActionResult> GetLetterEncumbrances(string loanId, string lang = "ru-RU")
        {
            LogMethod();
            var query = new GetLetterEncumbrancesQuery(loanId, lang);
            var terminatorReply = await Mediator.Send(query);
            return Ok(terminatorReply);

        }

        [HttpGet("get-blockchain-info")]
        [Authorize]
        public async Task<IActionResult> GetBlockchainInfo(string appId)
        {
            LogMethod();
            var query = new GetBlockchainInfoQuery(appId);
            var terminatorReply = await Mediator.Send(query);
            return Ok(terminatorReply);
        }

        [HttpPost("start-pledge-termination")]
        [Authorize]
        public async Task<IActionResult> StartPledgeTermination(StartPledgeTerminationRequestModel model)
        {
            LogMethod();
            var mapperCommand = Mapper.Map<StartPledgeTerminationCommand>(model);
            mapperCommand = new StartPledgeTerminationCommand(mapperCommand, User.Identity.Name);
            var terminatorReply = await Mediator.Send(mapperCommand);
            return Ok(terminatorReply);
        }

        [HttpPost("continue-pledge-termination")]
        [Authorize]
        public async Task<IActionResult> ContinuePledgeTermination(ContinuePledgeTerminationRequestModel model)
        {
            LogMethod();
            var mapperCommand = Mapper.Map<ContinuePledgeTerminationCommand>(model);
            var terminatorReply = await Mediator.Send(mapperCommand);
            return Ok(terminatorReply);
        }


        [HttpPost("pay-for-blockchain-termination")]
        [Authorize]
        public async Task<IActionResult> PayForPledgeTermination(ContinuePledgeTerminationRequestModel model)
        {
            LogMethod();
            var mapperCommand = Mapper.Map<PayForPledgeTerminationCommand>(model);
            var terminatorReply = await Mediator.Send(mapperCommand);
            return Ok(terminatorReply);
        }



    }
}
