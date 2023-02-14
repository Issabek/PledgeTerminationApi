using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using OtbasyBank.Application.Helpers;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
namespace OtbasyBank.Application.Queries.PledgeTerminator.CanBeTerminated
{
    public class CanBeTerminatedHandler : IRequestHandler<CanBeTerminatedQuery, bool>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        public CanBeTerminatedHandler(IPledgeTerminatorService pledgeTerminatorService)
        {
            _pledgeTerminatorService = pledgeTerminatorService; 

        }
        public async Task<bool> Handle(CanBeTerminatedQuery request, CancellationToken cancellationToken)
        {
            var result = await _pledgeTerminatorService.CanBeTerminated(request.LoanId);
            return result;
        }
    }
}
