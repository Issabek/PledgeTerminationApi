using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionError
    {
        /// <summary>
        /// ID записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентфикатор лота
        /// </summary>
        public int LotId { get; set; }
        /// <summary>
        /// Идентифкаор ставки
        /// </summary>
        public int? BidId { get; set; }
        /// <summary>
        /// Дата возникнования ошибки
        /// </summary>
        public DateTime ErrorDate { get; set; }
        /// <summary>
        /// Описание ошибки
        /// </summary>
        public string Error { get; set; } = null!;
        /// <summary>
        /// Стэк ошибки
        /// </summary>
        public string? ErrorStack { get; set; }
        /// <summary>
        /// Система в которой произошла ошибка
        /// </summary>
        public string SystemName { get; set; } = null!;

        public virtual DepositAuctionBid? Bid { get; set; }
        public virtual DepositAuctionLot Lot { get; set; } = null!;
    }
}
