using OtbasyBank.Domain.Entities;
using OtbasyBank.Shared.CustomModels;
using OtbasyBank.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace OtbasyBank.Application.Interfaces.Services
{
    public interface IPledgeTerminatorService
    {
        Task<Domain.Entities.UserFile> GetUserFile(long pledgeId);
        Task<XmlNode> GetLetterEncumbrances(string loanId);
        Task<bool> CanBeTerminated(string loanId);
        Task<bool> StartPledgeTermination(string appId, string loanId, string letterInfoData, string rka);
        void GetLetterInfo(ref PledgeTerminateModel model, string appId);
        Task<Domain.Entities.UserFileType> GetUserFileType(Shared.Enums.UserFileTypes type);
        Task<Domain.Entities.Client> GetClientByIIN(string iin);
        Task<BlockchainGetTerminatePledgeResponse> GetBlockchainInfo(string appId);
        Task<byte[]> SaveGeneratedPDF(string htmlString, UserFileTypes type, Domain.Entities.UserFileType userFileType, Domain.Entities.Client client, string fileName,string appId);
        Task<(long, long)> PayForPledgeTermination(PledgeTerminateModel model, string clientCode);
        Task<Domain.Entities.UserFile> GetUserFile(int userid, UserFileTypes type, string appId);
        bool SaveServiceFileQueue(MethodTypes type, string clientCode, string colvirReferenceId, byte[] content, int fileType, string fileName, string userName);
    }
}
