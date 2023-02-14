using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// Гарантийный взнос
    /// </summary>
    public partial class DepositAuctionBidPayment
    {
        public DepositAuctionBidPayment()
        {
            DepositAuctionBidPaymentLogs = new HashSet<DepositAuctionBidPaymentLog>();
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
        /// Идентификатор оплаты гарантийн
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Статус оплаты гарантийного взн
        /// </summary>
        public string? OrderStatus { get; set; }
        /// <summary>
        /// Дата и время обновления значен
        /// </summary>
        public DateTime? OrderStatusDate { get; set; }
        /// <summary>
        /// Данные запроса веб-сервиса сер
        /// </summary>
        public string? EpayWsInput { get; set; }
        /// <summary>
        /// Данные ответа веб-сервиса серв
        /// </summary>
        public string? EpayWsResponse { get; set; }
        /// <summary>
        /// Данные использованные для пере
        /// </summary>
        public string? EpayRedirectInfo { get; set; }
        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public DateTime? CreateDate { get; set; }

        public virtual DepositAuctionBid Bid { get; set; } = null!;
        public virtual ICollection<DepositAuctionBidPaymentLog> DepositAuctionBidPaymentLogs { get; set; }
    }
}
