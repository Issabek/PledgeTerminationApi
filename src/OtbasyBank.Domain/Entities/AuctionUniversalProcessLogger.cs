using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionUniversalProcessLogger
    {
        public AuctionUniversalProcessLogger()
        {
            AuctionUniversalProcessLoggerValues = new HashSet<AuctionUniversalProcessLoggerValue>();
        }

        public int Id { get; set; }
        public Guid PublicGuid { get; set; }
        public int TypeId { get; set; }
        public string? Step { get; set; }
        public DateTime Date { get; set; }
        public long UsersId { get; set; }
        public long? UsersUserId { get; set; }
        public string? Method { get; set; }
        public string? Exception { get; set; }

        public virtual AuctionUniversalProcessType Type { get; set; } = null!;
        public virtual User? UsersUser { get; set; }
        public virtual ICollection<AuctionUniversalProcessLoggerValue> AuctionUniversalProcessLoggerValues { get; set; }
    }
}
