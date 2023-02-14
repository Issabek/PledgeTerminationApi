using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionBid
    {
        public DepositAuctionBid()
        {
            DepositAuctionBidPaymentCurrAccs = new HashSet<DepositAuctionBidPaymentCurrAcc>();
            DepositAuctionBidPayments = new HashSet<DepositAuctionBidPayment>();
            DepositAuctionDocuments = new HashSet<DepositAuctionDocument>();
            DepositAuctionErrors = new HashSet<DepositAuctionError>();
        }

        /// <summary>
        /// Идентификатор ставки
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата создания ставки
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Идентификатор клиета
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Сумма ставки
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Идентификатор лота
        /// </summary>
        public int DepositAuctionLotId { get; set; }
        /// <summary>
        /// Статус ставки
        /// </summary>
        public int BidStatusId { get; set; }
        /// <summary>
        /// Контактная инормация
        /// </summary>
        public string? ContactInfo { get; set; }
        /// <summary>
        /// Идентфикаора процесса
        /// </summary>
        public long ProcessId { get; set; }
        /// <summary>
        /// Номер депозита для переноса гос премии
        /// </summary>
        public string? GosPremDepositId { get; set; }
        public string PaymentType { get; set; } = null!;
        public string RemainderPaymentType { get; set; } = null!;

        public virtual DepositAuctionBidStatus BidStatus { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual DepositAuctionLot DepositAuctionLot { get; set; } = null!;
        public virtual DepositAuctionBidProcess Process { get; set; } = null!;
        public virtual DepositAuctionBidGuaranteePayment DepositAuctionBidGuaranteePayment { get; set; } = null!;
        public virtual DepositAuctionBidGuaranteePaymentCurrAcc DepositAuctionBidGuaranteePaymentCurrAcc { get; set; } = null!;
        public virtual DepositAuctionWinnerBid DepositAuctionWinnerBid { get; set; } = null!;
        public virtual ICollection<DepositAuctionBidPaymentCurrAcc> DepositAuctionBidPaymentCurrAccs { get; set; }
        public virtual ICollection<DepositAuctionBidPayment> DepositAuctionBidPayments { get; set; }
        public virtual ICollection<DepositAuctionDocument> DepositAuctionDocuments { get; set; }
        public virtual ICollection<DepositAuctionError> DepositAuctionErrors { get; set; }
    }
}
