using Microsoft.Extensions.Configuration;
using OtbasyBank.Domain;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Domain.Exceptions;
using System.Xml;
using OtbasyBank.Application.Interfaces.Services;
using OtbasyBank.Infrastructure.Helpers;
using ClientWS;
using Microsoft.VisualStudio.Services.WebApi.Jwt;
using Newtonsoft.Json;
using OtbasyBank.Shared.CustomModels;

namespace OtbasyBank.Infrastructure.Services;

public class BusService : IBusService
{
    private readonly IConfiguration _configuration;
    private readonly SoapClient _soapClient;
    private readonly string _systemId;
    private readonly string _log;
    private readonly string _password;
    private string _token;


    public BusService(IConfiguration configuration)
    {
        _configuration = configuration;
        _soapClient = new(_configuration);
        _systemId = Crypt.Decrypt(_configuration["ServiceBus:SystemID"], "DdgtemId7", 0);
        _log = Crypt.Decrypt(_configuration["ServiceBus:Login"], "trohgFgh238476", 0);
        _password = Crypt.Decrypt(_configuration["ServiceBus:Password"], "fdgwoDd6784g6d4fg", 0);
        _token = GetToken();
    }

    public string GetToken()
    {
        var token = _soapClient.getTokenWSClient().UserLogin(new(_systemId, _log, _password)).UserLoginResult;
        if (token == "") { throw new InvalidTokenException("Token is null"); }
        return _soapClient.getTokenWSClient().UserLogin(new(_systemId, _log, _password)).UserLoginResult;
    }
    public void UpdateToken()
    {
        _token = GetToken();
    }
    public string POperPaySts(int? reference)
    {
        using (var account = _soapClient.getAccountWSClient())
        {
            return account.POperPaySts(new(_token, (long)reference)).POperPayStsResult;
        }
    }

    public long PCreatePay(string sKso_Code, string sCha_Code, string sCode_bc, string sKnp, string sCode_od, string sCode_be, string pDebetAcc, string pCreditAcc, decimal pAmount, string pTxt_Dscr)
    {
        using (var locAccount = _soapClient.getEpayAuctionWSClient())
        {
            return locAccount.PCreatePay(new(_token, sKso_Code, sCha_Code, sCode_bc, sKnp, sCode_od, sCode_be, pDebetAcc, pCreditAcc, pAmount, pTxt_Dscr)).PCreatePayResult;
        }
    }

    public (long, long) PCreateOutPay(string sKso_Code, string sCha_Code, string sCode_bc, string sKnp, string sCode_od, string sCode_be, string pDebetAcc,
                                string pCreditAcc, string pCliName, string pCliTaxCode, decimal pAmount, decimal pAmountCms, string pTxt_Dscr, string pTxt_Dscr_Cms,
                                long sReferItem, long sReferItemCms, string sGuide)
    {
        using (var locAccount = _soapClient.getAccountWSClient())
        {
            var a = locAccount.PCreateOutPay(new(_token, sKso_Code, sCha_Code, sCode_bc, sKnp, sCode_od, sCode_be, pDebetAcc, pCreditAcc, pCliName,
                                            pCliTaxCode, pAmount, pAmountCms, pTxt_Dscr, pTxt_Dscr_Cms, sReferItem, sReferItemCms, sGuide));
            return (a.sReferItem, a.sReferItemCms);
        }
    }

    public string GetClientCodeByIIN(string IIN)
    {
        using (var client = _soapClient.getClientWSClient())
        {
            return client.GetClientCodeByIIN(new(_token, IIN)).GetClientCodeByIINResult;
        }
    }

    public T GetClientByCode<T>(string clientCode) where T : class
    {
        using (var client = _soapClient.getClientWSClient())
        {
            return client.GetClientByCode(new(_token, clientCode, true, true, true, true, false, false)).GetClientByCodeResult as T;
        }
    }
    public T IsHaveTakeDocV2<T>(string colvirReferenceId) where T : class
    {
        using (var loan = _soapClient.getLoanWSClient())
        {
            return loan.IsHaveTakeDocV2(new(_token, colvirReferenceId)).IsHaveTakeDocV2Result as T;
        }
    }
    public T GetLetterEncumbrances<T>(string loanId) where T : class
    {
        using (var loan = _soapClient.getLoanWSClient())
        {
            return loan.GetLetterEncumbrances(new(_token, loanId)).GetLetterEncumbrancesResult as T;
        }
    }
    public T CreateRecordBlockChain<T>(string data, string signatures, string docHash, string name) where T : class
    {
        using (var blockchain = _soapClient.getBlockchainWSClient())
        {
            return blockchain.createRecord(new(_token, data, signatures, docHash, name)).createRecordResult as T;
        }
    }
    public T PayedRecord<T>(string data, string signatures, string docHash, string name) where T : class
    {
        using (var blockchain = _soapClient.getBlockchainWSClient())
        {
            return blockchain.payedRecord(new(_token, data, signatures, docHash, name)).payedRecordResult as T;
        }
    }

    public string Test()
    {
        using (var client = _soapClient.getClientWSClient())
        {
            var c = GetClientByCode<Client>("15.00695985");
        }
        using (var account = _soapClient.getAccountWSClient())
        {
            var b = account.GetPensionAccount(new(_token, "15.00695985")).GetPensionAccountResult.ToString();
            var a = GetPensionAccount<AccountWS.Account>("15.00695985");


            return a.ToString();
        }
    }

    public T GetPensionAccount<T>(string clientCode) where T : class
    {
        using (var account = _soapClient.getAccountWSClient())
        {
            return account.GetPensionAccount(new(_token, clientCode)).GetPensionAccountResult as T;
        }
    }
    public System.DateTime GetCurrentOperDay()
    {
        using (var reference = _soapClient.getReferenceWsClient())
        {
            return reference.GetCurrentOperDay(new(_token)).GetCurrentOperDayResult;
        }
    }
    public string CreateBlockchainRecord(BlockchainCreateDataModel model, PledgeSignatures signs, string docHash, string filebase64)
    {
        var dataJson = JsonConvert.SerializeObject(model);
        var signsJson = JsonConvert.SerializeObject(signs);
        using (var blockchain = _soapClient.getBlockchainWSClient())
        {
            return blockchain.createRecord(new(_token, dataJson, signsJson, filebase64, docHash)).createRecordResult;
        }
    }    
    public string PayedBlockchainRecord(PledgePayment model, PledgeSignatures signs, string docHash, string filebase64)
    {
        var dataJson = JsonConvert.SerializeObject(model);
        var signsJson = JsonConvert.SerializeObject(signs);
        using (var blockchain = _soapClient.getBlockchainWSClient())
        {
            return blockchain.payedRecord(new(_token, dataJson, signsJson, docHash, filebase64)).payedRecordResult;
        }
    }    

    public string GetZayavaRegNum(string clientIIN, string zayavaName)
    {
        using (var print = _soapClient.getPrintWSClient())
        {
            return print.GetZayavaRegNumString(new(_token, clientIIN, zayavaName)).GetZayavaRegNumStringResult;
        }
    }
    public T GetClientAccountByCode<T>(string clientCode) where T : class
    {

        using (var account = _soapClient.getAccountWSClient())
        {
            return account.GetClientAccount(new(_token, clientCode)).GetClientAccountResult as T;
        }
    }    
    
    public T GetBlockchainDocument<T>(string notifId) where T : class
    {

        using (var blockchain = _soapClient.getBlockchainWSClient())
        {
            return blockchain.getDocument(new(_token, notifId)).getDocumentResult as T;
        }
    }
}
