using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionDepositStatus
    {
        public AuctionDepositStatus()
        {
            AuctionCancelLogs = new HashSet<AuctionCancelLog>();
        }

        public int Id { get; set; }
        public string? Text { get; set; }
        public string? TextKz { get; set; }
        public string? TimelineRu { get; set; }
        public string? TimelineKz { get; set; }

        public virtual ICollection<AuctionCancelLog> AuctionCancelLogs { get; set; }
    }
}
