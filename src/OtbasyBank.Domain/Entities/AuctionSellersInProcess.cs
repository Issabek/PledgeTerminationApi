using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionSellersInProcess
    {
        public int Id { get; set; }
        public long UsersId { get; set; }
        public long? UsersUserId { get; set; }
        public int AuctionDepositsId { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Otp { get; set; }
        public string? Iban { get; set; }
        public int ProcessId { get; set; }
        public string? SellerAgreementHtml { get; set; }
        public DateTime? SellerAgreementSignDate { get; set; }
        public string? SellerAgreementHtmlKaz { get; set; }

        public virtual AuctionDeposit AuctionDeposits { get; set; } = null!;
        public virtual AuctionProcess Process { get; set; } = null!;
        public virtual User? UsersUser { get; set; }
    }
}
