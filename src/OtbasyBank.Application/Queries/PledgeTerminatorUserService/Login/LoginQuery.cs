using MediatR;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminatorUserService.Login
{
    public class LoginQuery : IRequest<GenericReply<string>>
    {
        public LoginQuery(string userName, string passWord)
        {
            UserName= userName;
            Password= passWord;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
