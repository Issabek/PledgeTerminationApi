using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionDocument
    {
        /// <summary>
        /// ID записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор лота
        /// </summary>
        public int LotId { get; set; }
        /// <summary>
        /// Идентфикатор ставки
        /// </summary>
        public int? BidId { get; set; }
        /// <summary>
        /// Наименование документа
        /// </summary>
        public string DocName { get; set; } = null!;
        /// <summary>
        /// Содержимое документа
        /// </summary>
        public string? DocBody { get; set; }
        /// <summary>
        /// Подпись
        /// </summary>
        public string? DocSignCode { get; set; }
        /// <summary>
        /// Информация об OTP
        /// </summary>
        public string? KeyInfo { get; set; }
        /// <summary>
        /// Присвоенные номер документа
        /// </summary>
        public string? DocumentNumber { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }

        public virtual DepositAuctionBid? Bid { get; set; }
        public virtual DepositAuctionLot Lot { get; set; } = null!;
    }
}
