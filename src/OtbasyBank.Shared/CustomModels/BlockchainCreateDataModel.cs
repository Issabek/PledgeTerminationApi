using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Shared.CustomModels
{

    public class BlockchainCreateDataModel
    {
        public string AppId { get; set; }
        public string RKA { get; set; }
        public string[] pledgerIds { get; set; }
        public string[] pledgeeIds { get; set; }
        public string payerIdn { get; set; }
        public string documentHash { get; set; }
        public DocumentInfo documentInfo { get; set; }
        public PledgeInfo[] pledgeInfo { get; set; }
        public Attachments[] attachments { get; set; }
    }
    public class DocumentInfo
    {
        public string docType { get; set; }
        public string docNumber { get; set; }
        public string docDate { get; set; }
    }

    public class PledgeSignatures
    {
        public string[] pledgers { get; set; }
        public string[] pledgees { get; set; }
    }

    public class PledgePayment
    {
        public string AppId { get; set; }
        public Payment[] payment { get; set; }
    }

    public class Payment
    {
        public decimal amount { get; set; }
        public string bankName { get; set; }
        public string bik { get; set; }
        public string callCenter { get; set; }
        public string numberBankTransaction { get; set; }
        public string numberCard { get; set; }
        public string payCode { get; set; }
        public string payDate { get; set; }
        public string payerIdn { get; set; }
        public string payDocHash { get; set; }
    }

    public class PledgeInfo
    {
        public string docNumber { get; set; }
        public string docDate { get; set; }
    }
    public class PledgeContract
    {
        public string AppId { get; set; }
        public string contractName { get; set; }
        public string documentHash { get; set; }
        public DocumentInfo documentInfo { get; set; }
        public string[] guarantorIds { get; set; }
        public Notification notification { get; set; }
        public string payerIdn { get; set; }
        public HardPayment[] payment { get; set; }
        public string[] pledgeeIds { get; set; }
        public string[] pledgerIds { get; set; }
        public Rejection rejection { get; set; }
        public string RKA { get; set; }
        public string status { get; set; }
        public Suspend suspend { get; set; }
        public string ErrorText { get; set; }
    }
    public class Attachments : DocumentInfo
    {
        public string docName { get; set; }
        public string docHash { get; set; }
    }
    public class PledgeTerminateModel
    {
        public PledgeTerminateLetterModel data { get; set; }
        public BlockchainGetTerminatePledgeResponse PledgeResponse { get; set; }
    }
    public class Suspend
    {
        public string[] finalOpinionKz { get; set; }
        public string[] finalOpinionRu { get; set; }
        public string notificationHash { get; set; }
        public string paymentData { get; set; }
        public string suspensionDate { get; set; }
        public string suspensionEliminateTerm { get; set; }
    }

    public class Notification
    {
        public string[] finalOpinionKz { get; set; }
        public string[] finalOpinionRu { get; set; }
        public string[] notificationHash { get; set; }
        public Nullable<bool> notificationType { get; set; }
        public string registerDate { get; set; }
        public string registerNum { get; set; }
    }

    public class Rejection
    {
        public string dateTime { get; set; }
        public string[] reasonKz { get; set; }
        public string[] reasonRu { get; set; }
    }

    public class HardPayment
    {
        public string amount { get; set; }
        public string bankName { get; set; }
        public string bik { get; set; }
        public string callCenter { get; set; }
        public string numberBankTransaction { get; set; }
        public string numberCard { get; set; }
        public string payCode { get; set; }
        public DateTime payDate { get; set; }
        public string payDocHash { get; set; }
        public string payerIdn { get; set; }
    }
    public class PaymentData
    {
        public string kbk;
        public string knp;
        public string bik;
        public string bin;
        public string knpName;
        public string kno;
        public string noName;
        public string noAccount;
        public decimal amountPay;
        public string serviceName;
        public string serviceDetail;
    }
    public class BlockchainGetTerminatePledgeResponse
    {
        public string AppId { get; set; }
        public PaymentData paymentData { get; set; }
        public string status { get; set; }
        public Suspend suspend { get; set; }
        public Notification notification { get; set; }
    }
    public class PledgeTerminateLetterModel
    {
        public int UserId { get; set; }
        public string AppId { get; set; }
        public string Rka { get; set; }
        public string LoanId { get; set; }
        public string LnCode { get; set; }
        public string DateBegin { get; set; }
        public string CliLongName { get; set; }
        public string FltAddress { get; set; }
        public string DclCode { get; set; }
        public string EnsCode { get; set; }
        public string DocNumber { get; set; }
        public string DocDate { get; set; }
        public string PledgeDocNumber { get; set; }
        public string PledgeDocDate { get; set; }
        public List<string> AdditionalDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalDocDate { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocDate { get; set; } = new List<string>();
        public List<string> TaxCodes { get; set; } = new List<string>();
        public List<string> CliCodes { get; set; } = new List<string>();
        public List<string> CliNames { get; set; } = new List<string>();
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime OperDate { get; set; }
        public string RegNum { get; set; }
        public bool IsHaveTakeDoc { get; set; }
    }
}
