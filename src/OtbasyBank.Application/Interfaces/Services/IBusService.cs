using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Application.Interfaces.Services
{
    public interface IBusService
    {

        T GetClientByCode<T>(string clientCode) where T : class;
        string GetClientCodeByIIN(string IIN);
        T GetClientAccountByCode<T>(string clientCode) where T : class;
        T GetPensionAccount<T>(string clientCode) where T : class;
        string GetToken();
        System.DateTime GetCurrentOperDay();
        (long, long) PCreateOutPay(string sKso_Code, string sCha_Code, string sCode_bc, string sKnp, string sCode_od, string sCode_be, string pDebetAcc, string pCreditAcc, string pCliName, string pCliTaxCode, decimal pAmount, decimal pAmountCms, string pTxt_Dscr, string pTxt_Dscr_Cms, long sReferItem, long sReferItemCms, string sGuide);
        long PCreatePay(string sKso_Code, string sCha_Code, string sCode_bc, string sKnp, string sCode_od, string sCode_be, string pDebetAcc, string pCreditAcc, decimal pAmount, string pTxt_Dscr);
        string POperPaySts(int? reference);
        string Test();
        void UpdateToken();
        string GetZayavaRegNum(string clientIIN, string zayavaName);
        T IsHaveTakeDocV2<T>(string colvirReferenceId) where T : class;
        T GetLetterEncumbrances<T>(string loanId) where T : class;
        T GetBlockchainDocument<T>(string notifId) where T : class;
        T CreateRecordBlockChain<T>(string data, string signatures, string docHash, string name) where T : class;
        string PayedBlockchainRecord(PledgePayment model, PledgeSignatures signs, string docHash, string filebase64);
        string CreateBlockchainRecord(BlockchainCreateDataModel model, PledgeSignatures signs, string docHash, string filebase64);
    }
}
