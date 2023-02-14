using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// Гарантийный взнос
    /// </summary>
    public partial class DepositAuctionBidGuaranteePayment
    {
        public DepositAuctionBidGuaranteePayment()
        {
            DepositAuctionBidGuaranteePaymentLogs = new HashSet<DepositAuctionBidGuaranteePaymentLog>();
        }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ссылка на идентификатор ставки
        /// </summary>
        public int BidId { get; set; }
        /// <summary>
        /// Идентификатор оплаты гарантийного взноса
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
        /// Данные запроса веб-сервиса сервисной шины
        /// </summary>
        public string? EpayWsInput { get; set; }
        /// <summary>
        /// Данные ответа веб-сервиса сервисной шины
        /// </summary>
        public string? EpayWsResponse { get; set; }
        /// <summary>
        /// Данные использованные для переадресации на портал оплаты EPay
        /// </summary>
        public string? EpayRedirectInfo { get; set; }
        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public DateTime? CreateDate { get; set; }

        public virtual DepositAuctionBid Bid { get; set; } = null!;
        public virtual ICollection<DepositAuctionBidGuaranteePaymentLog> DepositAuctionBidGuaranteePaymentLogs { get; set; }
    }
}
