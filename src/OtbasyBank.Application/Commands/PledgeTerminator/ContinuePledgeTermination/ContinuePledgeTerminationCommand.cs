using MediatR;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Commands.PledgeTerminator.ContinuePledgeTerminationCommand
{
    public class ContinuePledgeTerminationCommand : IRequest<GenericReply<string>>
    {
        public string Lang { get; set; }
        public string AppId { get; set; }
        public string Iin { get; set; }
        public ContinuePledgeTerminationCommand()
        {

        }
        public ContinuePledgeTerminationCommand(string appId, string iin, string lang="ru-RU")
        {
            Lang = lang;
            AppId = appId;
            Iin = iin;
        }
    }
}
