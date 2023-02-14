using MediatR;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetBlockchainInfo
{
    public class GetBlockchainInfoQuery : IRequest<GenericReply<BlockchainGetTerminatePledgeResponse>>
    {
        public string AppId { get; set; }
        public GetBlockchainInfoQuery(string appId)
        {
            AppId = appId;
        }
    }
}
