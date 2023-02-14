using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// История статусов платежа выкупа депозита
    /// </summary>
    public partial class DepositAuctionBidPaymentLog
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ссылка на идентификатор оплаты выкупа депозита
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Статус оплаты выкупа депозита
        /// </summary>
        public string? OrderStatus { get; set; }
        /// <summary>
        /// Дата и время обновления значения статуса оплаты выкупа депозита в этой таблице
        /// </summary>
        public DateTime? OrderStatusDate { get; set; }
        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public DateTime CreateDate { get; set; }

        public virtual DepositAuctionBidPayment Order { get; set; } = null!;
    }
}
