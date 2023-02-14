using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionSubAgreement
    {
        public int Id { get; set; }
        public int AuctionDepositsId { get; set; }
        public string? SubAgreementId { get; set; }
        public string? SubAgreementNumber { get; set; }
        public DateTime SubAgreementStartDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? SubAgreementStopDate { get; set; }

        public virtual AuctionDeposit AuctionDeposits { get; set; } = null!;
    }
}
