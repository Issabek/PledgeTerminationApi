using AutoMapper;
using OtbasyBank.Api.Models;
using OtbasyBank.Api.Models.ApiRequestModels.PledgeTerminator;
using OtbasyBank.Api.Models.ApiResponseModels.PledgeTerminator;
using OtbasyBank.Api.Models.Replies;
using OtbasyBank.Application.Commands.PledgeTerminator.ContinuePledgeTerminationCommand;
using OtbasyBank.Application.Commands.PledgeTerminator.StartPledgeTermination;
using OtbasyBank.Shared.CustomModels;

namespace OtbasyBank.Api.Profiles;

/// <summary>
/// AutoMapper profile
/// </summary>
public class ReplyProfile : Profile
{
    /// <summary>
    /// Start mapping
    /// </summary>
    public ReplyProfile()
    {
        this.CreateMap<GenericReply<UserFileResponseModel>,
            GenericReply<Domain.Entities.UserFile>>()
            .ReverseMap();        
        this.CreateMap<UserFileResponseModel,
            Domain.Entities.UserFile>()
            .ReverseMap();        
        this.CreateMap<GetLetterEncumbrancesResponseModel,
            LetterEncumbrancesModel>()
            .ReverseMap();          
        this.CreateMap<GetBlockchainInfoResponseModel,
            BlockchainGetTerminatePledgeResponse>()
            .ReverseMap();        
        this.CreateMap<GenericReply<GetLetterEncumbrancesResponseModel>,
            GenericReply<LetterEncumbrancesModel>>()
            .ReverseMap();        
        this.CreateMap<GenericReply<GetBlockchainInfoResponseModel>,
            GenericReply<BlockchainGetTerminatePledgeResponse>>()
            .ReverseMap();
        this.CreateMap<StartPledgeTerminationRequestModel, StartPledgeTerminationCommand>().ReverseMap();
        this.CreateMap<GetBlockchainInfoResponseModel, StartPledgeTerminationCommand>().ReverseMap();
        this.CreateMap<ContinuePledgeTerminationCommand, ContinuePledgeTerminationRequestModel>().ReverseMap();
        this.CreateMap<GetBlockchainInfoResponseModel, PledgeTerminateModel>().ReverseMap();
    }
}
