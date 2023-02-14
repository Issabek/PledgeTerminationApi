using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ConcessionsForClientsGlobalView
    {
        public string SellerIin { get; set; } = null!;
        public long SellerUserId { get; set; }
        public string SellerFio { get; set; } = null!;
        public string BuyerIin { get; set; } = null!;
        public long BuyerUserId { get; set; }
        public string BuyerFio { get; set; } = null!;
        public int AuctionDepositId { get; set; }
        public int? ProcessId { get; set; }
        public decimal Price { get; set; }
        public decimal Saldo { get; set; }
        public decimal BankCommission { get; set; }
        public decimal? Summ { get; set; }
        public DateTime AuctionCreateDate { get; set; }
        public DateTime AuctionDepositCreateDate { get; set; }
        public int AuctionDepositStatusId { get; set; }
        public string? TimelineRu { get; set; }
    }
}
