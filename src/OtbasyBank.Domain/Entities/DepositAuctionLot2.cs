using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionLot2
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public int ClientId { get; set; }
        public string DepositId { get; set; } = null!;
        public decimal StartingPrice { get; set; }
        public int DepositAuctionLotStatusId { get; set; }
        public decimal BidStep { get; set; }
        public decimal SecurityDeposit { get; set; }
        public string DepositData { get; set; } = null!;
        public int PerformanceIndicator { get; set; }
        public decimal TotalAccumulations { get; set; }
        public DateTime DepositCreateDate { get; set; }
        public long ProcessId { get; set; }
        public int AuctionDuration { get; set; }
        public string? GosPremDepositId { get; set; }
        public string? Iban { get; set; }
        public bool AreLostBidsHandled { get; set; }
        public DateTime? SellerSignDate { get; set; }
        public DateTime? BuyerSignDate { get; set; }
        public string? Email { get; set; }
        public decimal FullReward { get; set; }
        public decimal AgreementSum { get; set; }
        public string? DepositNumber { get; set; }
        public long? BlockId { get; set; }
        public string? ConcessionDepositId { get; set; }
        public decimal CommissionOfTheBank { get; set; }
        public bool IsCreatePayment { get; set; }
        public DateTime? SignDate { get; set; }
        public decimal? TotalAccumulationsOnStart { get; set; }
        public string? CessionSessionId { get; set; }
    }
}
