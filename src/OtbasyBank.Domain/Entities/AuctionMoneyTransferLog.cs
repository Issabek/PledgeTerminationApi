using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionMoneyTransferLog
    {
        public long Id { get; set; }
        public decimal Sum { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastTryDate { get; set; }
        public string? Exception { get; set; }
        public int TryCount { get; set; }
        public int AuctionProcessId { get; set; }
        public int AuctionDepositsId { get; set; }
        public long BuyerUserId { get; set; }
        public long SellerUserId { get; set; }
        public bool IsMoneyTransferred { get; set; }
        public long? BuyerUserUserId { get; set; }
        public long? SellerUserUserId { get; set; }
        public int? WsOrderIdBtoS { get; set; }
        public int? WsOrderIdCommision { get; set; }
        public bool IsCommissionTransferred { get; set; }
        public decimal BankCommission { get; set; }
        public bool IsSubAgreementSent { get; set; }
        public string? PaymentSguide { get; set; }

        public virtual AuctionDeposit AuctionDeposits { get; set; } = null!;
        public virtual AuctionProcess AuctionProcess { get; set; } = null!;
        public virtual User? BuyerUserUser { get; set; }
        public virtual User? SellerUserUser { get; set; }
    }
}
