using MediatR;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Commands.PledgeTerminator.StartPledgeTermination
{
    public class StartPledgeTerminationCommand : IRequest<GenericReply<string>>
    {
        public string ClientIIN { get; set; }
        public string LoanId { get; set; }
        internal string SysUserName { get; set; }
        public string RKA { get; set; }
        public StartPledgeTerminationCommand()
        {

        }
        public StartPledgeTerminationCommand(StartPledgeTerminationCommand model, string SysUserName)
        {
            this.ClientIIN = model.ClientIIN;
            this.SysUserName = SysUserName;
            this.RKA=model.RKA;
            this.LoanId=model.LoanId; 
        }
    }
}
