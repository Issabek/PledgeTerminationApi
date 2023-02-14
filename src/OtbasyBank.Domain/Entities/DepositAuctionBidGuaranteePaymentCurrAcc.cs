using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// Гарантийный взнос
    /// </summary>
    public partial class DepositAuctionBidGuaranteePaymentCurrAcc
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ссылка на идентификатор ставки
        /// </summary>
        public int BidId { get; set; }
        /// <summary>
        /// Статус оплаты гарантийного взноса
        /// </summary>
        public string? OrderStatus { get; set; }
        /// <summary>
        /// Дата и время обновления значения статуса оплаты гарантийного взноса в этой таблице
        /// </summary>
        public DateTime? OrderStatusDate { get; set; }
        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public DateTime? CreateDate { get; set; }
        public string? CurrAccIban { get; set; }

        public virtual DepositAuctionBid Bid { get; set; } = null!;
    }
}
