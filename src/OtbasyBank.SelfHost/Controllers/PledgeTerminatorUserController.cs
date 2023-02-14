using Microsoft.AspNetCore.Mvc;
using OtbasyBank.Application.Queries.PledgeTerminatorUserService.Login;

namespace OtbasyBank.Api.Controllers
{
    [ApiController]
    [Route("api/application")]
    public class PledgeTerminatorUserController : BaseController
    {

        [HttpPost("login")]
        public async Task<IActionResult> GetToken(string login,string pass)
        {
            var query = new LoginQuery(login,pass);
            var terminatorReply = await Mediator.Send(query);
            return Ok(terminatorReply);
        }

    }
}


