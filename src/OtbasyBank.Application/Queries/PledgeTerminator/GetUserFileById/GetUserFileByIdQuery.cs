using MediatR;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetUserFileById
{
    public class GetUserFileByIdQuery : IRequest<GenericReply<Domain.Entities.UserFile>>
    {
        public GetUserFileByIdQuery(long fileId)
        {
            Id = fileId;
        }

        public long Id { get; set; }
    }
}
