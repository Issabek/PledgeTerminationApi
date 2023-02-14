using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ConcessionsForClientsView
    {
        public string SellerIin { get; set; } = null!;
        public string SellerFio { get; set; } = null!;
        public string BuyerIin { get; set; } = null!;
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
