using MediatR;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetBlockchainInfo
{
    public class GetBlockchainInfoHandler : IRequestHandler<GetBlockchainInfoQuery, GenericReply<BlockchainGetTerminatePledgeResponse>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        public GetBlockchainInfoHandler(IPledgeTerminatorService pledgeTerminatorService)
        {
            _pledgeTerminatorService = pledgeTerminatorService;
        }

        public async Task<GenericReply<BlockchainGetTerminatePledgeResponse>> Handle(GetBlockchainInfoQuery request, CancellationToken cancellationToken)
        {
            GenericReply<BlockchainGetTerminatePledgeResponse> reply = new();
            try
            {
                var result = await _pledgeTerminatorService.GetBlockchainInfo(request.AppId);
                reply.Add(result);
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;
        }
    }
}
