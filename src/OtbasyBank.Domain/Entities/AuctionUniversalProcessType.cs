using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionUniversalProcessType
    {
        public AuctionUniversalProcessType()
        {
            AuctionUniversalProcessLoggers = new HashSet<AuctionUniversalProcessLogger>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<AuctionUniversalProcessLogger> AuctionUniversalProcessLoggers { get; set; }
    }
}
