using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// История статусов платежа гарантийного взноса
    /// </summary>
    public partial class DepositAuctionBidGuaranteePaymentLog
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ссылка на идентификатор оплаты гарантийного взноса
        /// </summary>
        public int OrderId { get; set; }
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
        public DateTime CreateDate { get; set; }

        public virtual DepositAuctionBidGuaranteePayment Order { get; set; } = null!;
    }
}
