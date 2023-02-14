using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionWinnerBid
    {
        /// <summary>
        /// Идентификатор лота
        /// </summary>
        public int DepositAuctionLotId { get; set; }
        /// <summary>
        /// Идентификатор ставки победителя
        /// </summary>
        public int DepositAuctionBidId { get; set; }

        public virtual DepositAuctionBid DepositAuctionBid { get; set; } = null!;
        public virtual DepositAuctionLot DepositAuctionLot { get; set; } = null!;
    }
}
