using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionDepositsTransferLog
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int AuctionProcessId { get; set; }
        public int AuctionDepositsId { get; set; }
        public long SellerUserId { get; set; }
        public long BuyerUserId { get; set; }
        public bool IsDepositTransferred { get; set; }
        public int TryCount { get; set; }
        public string? Exception { get; set; }
        public DateTime? LastTryDate { get; set; }
        public long? BuyerUserUserId { get; set; }
        public long? SellerUserUserId { get; set; }
        public string? WsSessionId { get; set; }
        public string? WsConcessionDepositId { get; set; }
    }
}
