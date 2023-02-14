using MediatR;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Commands.PledgeTerminator.PayForPledgeTermination
{
    public class PayForPledgeTerminationCommand : IRequest<GenericReply<PledgeTerminateModel>>
    {
        public string IIN{ get; set; }
        public string AppId { get; set; }
        public string UserName { get; set; }
        public string Lang { get; set; }
    }
}
