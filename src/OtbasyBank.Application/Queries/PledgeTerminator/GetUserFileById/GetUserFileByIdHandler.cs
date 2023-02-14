using MediatR;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain;
using OtbasyBank.Domain.Replies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Queries.PledgeTerminator.GetUserFileById
{
    public class GetUserFileByIdHandler : IRequestHandler<GetUserFileByIdQuery, GenericReply<Domain.Entities.UserFile>>
    {
        private readonly IPledgeTerminatorService _pledgeTerminatorService;
        public GetUserFileByIdHandler(IPledgeTerminatorService pledgeTerminatorSerivce)
        {
            _pledgeTerminatorService = pledgeTerminatorSerivce;
        }
        public async Task<GenericReply<Domain.Entities.UserFile>> Handle(GetUserFileByIdQuery request, CancellationToken cancellationToken)
        {
            GenericReply<Domain.Entities.UserFile> reply = new();
            try
            {
                var response = await _pledgeTerminatorService.GetUserFile(request.Id);
                reply.Add(response);
            }
            catch (Exception ex)
            {
                reply.AddError(ex);
            }
            return reply;
        }
    }
}
