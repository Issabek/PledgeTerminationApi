using MediatR;
using OtbasyBank.Shared.CustomModels;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetLetterEncumbrances
{
    public class GetLetterEncumbrancesHandler : IRequestHandler<GetLetterEncumbrancesQuery, GenericReply<LetterEncumbrancesModel>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        public GetLetterEncumbrancesHandler(IPledgeTerminatorService pledgeTerminatorService)
        {
            _pledgeTerminatorService = pledgeTerminatorService;
        }
        public async Task<GenericReply<LetterEncumbrancesModel>> Handle(GetLetterEncumbrancesQuery request, CancellationToken cancellation)
        {
            GenericReply<LetterEncumbrancesModel> reply = new();
            try
            {
                var xmlHolder = await _pledgeTerminatorService.GetLetterEncumbrances(request.LoanId);
                if (xmlHolder == null)
                {
                    throw new NullReferenceException(nameof(xmlHolder));

                }
                reply.Add(new LetterEncumbrancesModel(xmlHolder));
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;
        }
    }
}
