using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionParameter
    {
        public decimal SecurityDeposit { get; set; }
        public decimal BidStep { get; set; }
        public int Duration { get; set; }
    }
}
