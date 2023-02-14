using MediatR;
using OtbasyBank.Shared.CustomModels;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetLetterEncumbrances
{
    public class GetLetterEncumbrancesQuery : IRequest<GenericReply<LetterEncumbrancesModel>>
    {
        public string LoanId { get; set; }
        public string Lang { get; set; }
        public GetLetterEncumbrancesQuery(string loanId, string lang)
        {
            LoanId = loanId;
            Lang = lang;
        }
    }
}
