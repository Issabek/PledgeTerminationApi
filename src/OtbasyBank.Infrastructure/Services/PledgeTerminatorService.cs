using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OtbasyBank.Application.Interfaces.Persistence;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Replies;
using OtbasyBank.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OtbasyBank.Shared.CustomModels;
using Newtonsoft.Json;
using OtbasyBank.Shared.Enums;

namespace OtbasyBank.Infrastructure.Services
{
    public class PledgeTerminatorService : IPledgeTerminatorService
    {
        private readonly IInternetBankingContext _context;
        private readonly IBusService _busService;
        private readonly IConfiguration _config;
        private readonly RetryExecutor _retryExecutor;

        public PledgeTerminatorService(IInternetBankingContext context, IBusService busService, IConfiguration config)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _busService = busService ?? throw new ArgumentNullException(nameof(busService));
            _retryExecutor = new(_busService);
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public async Task<Domain.Entities.UserFile> GetUserFile(long fileId)
        {
            var item = await _context.UserFiles.FirstOrDefaultAsync(f => f.UserFileId == fileId);
            if (item == null)
                throw new NullReferenceException(nameof(item));
            return item;
        }

        public async Task<bool> CanBeTerminated(string loanId)
        {
            var result = _retryExecutor.Retry(() =>
             _busService.IsHaveTakeDocV2<LoanWS.TakeDocFlag>(loanId),
                int.Parse(_config["ServiceBus:RetryMaxAttempts"]),
                int.Parse(_config["ServiceBus:RetryInterval"]));
            if (result == null)
                throw new NullReferenceException(nameof(result));
            return result.oENS2 == 1 && result.oDZN == 1 && result.oENS4 == 0;
        }

        public async Task<XmlNode> GetLetterEncumbrances(string loanId)
        {
            var result = _retryExecutor.Retry(() =>
             _busService.GetLetterEncumbrances<XmlNode>(loanId),
                int.Parse(_config["ServiceBus:RetryMaxAttempts"]),
                int.Parse(_config["ServiceBus:RetryInterval"]));
            if (result == null)
                throw new NullReferenceException(nameof(result));
            return result;
        }

        public void GetLetterInfo(ref PledgeTerminateModel model, string appId)
        {
            var data = _context.BlockchainOperations.FirstOrDefault(o => o.AppId == appId);
            model.data = JsonConvert.DeserializeObject<PledgeTerminateLetterModel>(data.LetterInfo);
            model.data.AppId = data.AppId;
            model.data.Rka = data.Rka;
            if (data.Parameters != null)
            {
                model.PledgeResponse = JsonConvert.DeserializeObject<BlockchainGetTerminatePledgeResponse>(data.Parameters);
            }
            else
                model.PledgeResponse = null;
        }



        public async Task<Domain.Entities.UserFileType> GetUserFileType(Shared.Enums.UserFileTypes type)
        {
            var fileType = await _context.UserFileTypes.FirstOrDefaultAsync(f => f.FileTypeId == (int)type);
            return fileType;
        }

        public async Task<byte[]> SaveGeneratedPDF(string htmlString, UserFileTypes type, Domain.Entities.UserFileType userFileType, Domain.Entities.Client client, string fileName, string appId)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(htmlString);
            _context.UserFiles.Add(new Domain.Entities.UserFile()
            {
                UserId = client.UserId,
                ClientCode = client.ClientCode,
                ClientId = client.ClientId,
                ClientIin = client.ClientIin,
                FileTypeId = (int)type,
                BankFileId = (long)userFileType.BankFileTypeId,
                UserFileGuid = Guid.NewGuid(),
                FileName = fileName,
                SourceReqCode = appId,
                SourceSystem = 17,
                FileData = bytes,
                Uploaded = DateTime.Now,
                Deleted = null
            }) ;
            _context.SaveChanges();
            return bytes;
        }
        public async Task<Domain.Entities.UserFile> GetUserFile(int userid, UserFileTypes type, string appId)
        {
            var file = await _context.UserFiles.FirstOrDefaultAsync(f => f.UserId == userid && f.FileTypeId == (int)type && f.SourceReqCode == appId);
            return file;
        }
        public async Task<Domain.Entities.Client> GetClientByIIN(string iin)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(u => u.ClientIin == iin);
            if (client == null)
                throw new NullReferenceException(nameof(client));
            return client;
        }
        public async Task<bool> StartPledgeTermination(string appId, string loanId, string letterInfoData, string rka)
        {
            var newBcOperation = new Domain.Entities.BlockchainOperation()
            {
                Stage = "Start",
                LoanId = loanId,
                PledgeId = "",
                AppId = appId,
                LetterInfo = letterInfoData,
                Rka = rka
            };
            _context.BlockchainOperations.Add(newBcOperation);
            return _context.SaveChanges() > 0;
        }

        public async Task<BlockchainGetTerminatePledgeResponse> GetBlockchainInfo(string appId)
        {
            var info = await _context.BlockchainOperations.FirstOrDefaultAsync(f => f.AppId == appId);
            if (info == null)
            {
                throw new NullReferenceException(nameof(info));
            }
            if (info.Parameters == null)
            {
                throw new NullReferenceException("Pledge parameters are not updated yet!");

            }
            return JsonConvert.DeserializeObject<BlockchainGetTerminatePledgeResponse>(info.Parameters);

        }
        public async Task<(long, long)> PayForPledgeTermination(PledgeTerminateModel model, string clientCode)
        {
            long sReferItem = 0, sReferItemCms = 0;
            var account = _retryExecutor.Retry(() =>
                         _busService.GetClientAccountByCode<AccountWS.Account>(clientCode),
                            int.Parse(_config["ServiceBus:RetryMaxAttempts"]),
                            int.Parse(_config["ServiceBus:RetryInterval"]));
            var result = _retryExecutor.Retry(() =>
                        _busService.PCreateOutPay(
                            "311",
                            "0201117",
                            "105429",
                            model.PledgeResponse.paymentData.knp == "991" ? "911" : model.PledgeResponse.paymentData.knp,
                            "19",
                            "11",
                            account.Code,
                            model.PledgeResponse.paymentData.noAccount,
                            model.PledgeResponse.paymentData.noName,
                            "160440007161",
                            model.PledgeResponse.paymentData.amountPay,
                            0,
                            model.PledgeResponse.paymentData.knpName,
                            "Комиссия",
                             sReferItem,
                             sReferItemCms,
                            (new Guid()).ToString()),
                           int.Parse(_config["ServiceBus:RetryMaxAttempts"]),
                           int.Parse(_config["ServiceBus:RetryInterval"]));
            return (result.Item1, result.Item2);
        }

        public bool SaveServiceFileQueue(MethodTypes type, string clientCode, string colvirReferenceId, byte[] content, int fileType, string fileName, string userName)
        {
            Domain.Entities.ServiceFile newFile = new Domain.Entities.ServiceFile()
            {
                ColvirReferenceId = colvirReferenceId, 
                ClientCode = clientCode,
                ServiceMethod = MethodNames.GetName(type),
                FileContent = content,
                FileName = fileName,
                FileType = fileType,
                UserBranchName = userName,
                UserDepName="",
                IsCopied=5

            };
            _context.ServiceFiles.Add(newFile);
            var res = _context.SaveChanges();
            return res > 0;
        }
    }
}