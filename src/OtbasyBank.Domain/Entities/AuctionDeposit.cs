using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionDeposit
    {
        public AuctionDeposit()
        {
            AuctionCancelLogs = new HashSet<AuctionCancelLog>();
            AuctionMoneyTransferLogs = new HashSet<AuctionMoneyTransferLog>();
            AuctionSellersInProcesses = new HashSet<AuctionSellersInProcess>();
            AuctionSubAgreements = new HashSet<AuctionSubAgreement>();
        }

        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? DepositId { get; set; }
        public string? DisplaydepositId { get; set; }
        public decimal FullReward { get; set; }
        public decimal GosReward { get; set; }
        public decimal LastYearReward { get; set; }
        public decimal Saldo { get; set; }
        public long? NewOwnerUserId { get; set; }
        public decimal TotalAccumulations { get; set; }
        public DateTime DepositCreateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int SellStepsId { get; set; }
        public int StatusId { get; set; }
        public decimal BankCommission { get; set; }
        public int LastStatusId { get; set; }
        public int? BuyStepsId { get; set; }
        public int? ProcessId { get; set; }
        public bool? SellerSendNotification { get; set; }
        public bool? BuyerSendNotification { get; set; }

        public virtual ICollection<AuctionCancelLog> AuctionCancelLogs { get; set; }
        public virtual ICollection<AuctionMoneyTransferLog> AuctionMoneyTransferLogs { get; set; }
        public virtual ICollection<AuctionSellersInProcess> AuctionSellersInProcesses { get; set; }
        public virtual ICollection<AuctionSubAgreement> AuctionSubAgreements { get; set; }
    }
}
