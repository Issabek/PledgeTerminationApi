using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionBlockList
    {
        public int AuctionDepositId { get; set; }
        public DateTime UnblockTime { get; set; }
    }
}
