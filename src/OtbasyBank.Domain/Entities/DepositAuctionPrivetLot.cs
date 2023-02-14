using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionPrivetLot
    {
        /// <summary>
        /// Идентификатор лота
        /// </summary>
        public int LotId { get; set; }
        /// <summary>
        /// ИИН покупателя
        /// </summary>
        public string BuyerIin { get; set; } = null!;

        public virtual DepositAuctionLot Lot { get; set; } = null!;
    }
}
