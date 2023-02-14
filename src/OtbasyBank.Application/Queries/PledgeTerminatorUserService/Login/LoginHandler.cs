using MediatR;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminatorUserService.Login
{
    public class LoginHandler : IRequestHandler<LoginQuery, GenericReply<string>>
    {
        private readonly IPledgeTerminatorUserService _pledgeTerminatorUserService;
        public LoginHandler(IPledgeTerminatorUserService pledgeTerminatorUserService)
        {
            _pledgeTerminatorUserService = pledgeTerminatorUserService;
        }
        public async Task<GenericReply<string>> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            GenericReply<string> reply = new();
            try
            {
                reply.Add(_pledgeTerminatorUserService.Login(request.UserName, request.Password));
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }

            return reply;
        }
    }
}
