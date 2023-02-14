using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionBidHistory
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор ставки
        /// </summary>
        public int BidId { get; set; }
        /// <summary>
        /// Время создания ставки
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// ID клинта
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Сумма ставки
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// ID лота
        /// </summary>
        public int DepositAuctionLotId { get; set; }
        /// <summary>
        /// Статус ставки
        /// </summary>
        public int BidStatusId { get; set; }
        /// <summary>
        /// Контактные данные
        /// </summary>
        public string? ContactInfo { get; set; }
        /// <summary>
        /// ID процесса
        /// </summary>
        public long ProcessId { get; set; }
        /// <summary>
        /// ID депозита для переноса гос премии
        /// </summary>
        public string? GosPremDepositId { get; set; }
        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime ChangeDate { get; set; }
    }
}
