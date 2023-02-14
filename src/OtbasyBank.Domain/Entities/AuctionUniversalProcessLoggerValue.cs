using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionUniversalProcessLoggerValue
    {
        public int Id { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }
        public int AuctionUniversalProcessLoggerId { get; set; }

        public virtual AuctionUniversalProcessLogger AuctionUniversalProcessLogger { get; set; } = null!;
    }
}
