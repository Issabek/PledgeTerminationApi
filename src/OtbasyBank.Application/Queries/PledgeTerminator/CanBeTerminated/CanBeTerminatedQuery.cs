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
    public class CanBeTerminatedQuery: IRequest<bool>
    {

        public CanBeTerminatedQuery(string loanId)
        {
            this.LoanId = loanId;
        }

        public string LoanId { get; set; }
    }
}
