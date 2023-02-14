using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionBidStatus
    {
        public DepositAuctionBidStatus()
        {
            DepositAuctionBids = new HashSet<DepositAuctionBid>();
        }

        /// <summary>
        /// ID статуса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование статуса
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<DepositAuctionBid> DepositAuctionBids { get; set; }
    }
}
