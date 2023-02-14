using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionProcess
    {
        public AuctionProcess()
        {
            AuctionCancelLogs = new HashSet<AuctionCancelLog>();
            AuctionLogs = new HashSet<AuctionLog>();
            AuctionMoneyTransferLogs = new HashSet<AuctionMoneyTransferLog>();
            AuctionSellersInProcesses = new HashSet<AuctionSellersInProcess>();
        }

        public int Id { get; set; }
        public int UsersId { get; set; }
        public long? UsersUserId { get; set; }
        public bool ProcessIsEnd { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Otp { get; set; }
        public string? Iban { get; set; }
        public string? BuyerAgreementHtml { get; set; }
        public DateTime? BuyerAgreementSignDate { get; set; }
        public int BuyStepsId { get; set; }
        public string? BuyerAgreementHtmlKaz { get; set; }

        public virtual AuctionBuyStep BuySteps { get; set; } = null!;
        public virtual User? UsersUser { get; set; }
        public virtual ICollection<AuctionCancelLog> AuctionCancelLogs { get; set; }
        public virtual ICollection<AuctionLog> AuctionLogs { get; set; }
        public virtual ICollection<AuctionMoneyTransferLog> AuctionMoneyTransferLogs { get; set; }
        public virtual ICollection<AuctionSellersInProcess> AuctionSellersInProcesses { get; set; }
    }
}
