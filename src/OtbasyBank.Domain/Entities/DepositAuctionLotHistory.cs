using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionLotHistory
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
        /// Дата начала торгов
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Дата завершения торгов
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Дата фактического завершения
        /// </summary>
        public DateTime? ActualEndDate { get; set; }
        /// <summary>
        /// Идентфикатор клиета
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Идентфикатор депозита
        /// </summary>
        public string DepositId { get; set; } = null!;
        /// <summary>
        /// Начальная цена
        /// </summary>
        public decimal StartingPrice { get; set; }
        /// <summary>
        /// Статус лота
        /// </summary>
        public int DepositAuctionLotStatusId { get; set; }
        /// <summary>
        /// Шаг увеличение стоимости
        /// </summary>
        public decimal BidStep { get; set; }
        /// <summary>
        /// Сумма гарантийного взноса
        /// </summary>
        public decimal SecurityDeposit { get; set; }
        /// <summary>
        /// Сериализованная модель депозита
        /// </summary>
        public string? DepositData { get; set; }
        /// <summary>
        /// Оценочный показатель
        /// </summary>
        public int PerformanceIndicator { get; set; }
        /// <summary>
        /// Сумма накоплений
        /// </summary>
        public decimal TotalAccumulations { get; set; }
        /// <summary>
        /// Дата открытия депозита
        /// </summary>
        public DateTime DepositCreateDate { get; set; }
        /// <summary>
        /// Идентификатор процесса в рамках которого появилась запись
        /// </summary>
        public long ProcessId { get; set; }
        /// <summary>
        /// Продолжительность жизни лота (дней)
        /// </summary>
        public int AuctionDuration { get; set; }
        /// <summary>
        /// Идентификатор депозита для переноса гос премии
        /// </summary>
        public string? GosPremDepositId { get; set; }
        /// <summary>
        /// Номер счета
        /// </summary>
        public string? Iban { get; set; }
        /// <summary>
        /// Флаг обработки проигравших ставок
        /// </summary>
        public bool AreLostBidsHandled { get; set; }
        /// <summary>
        /// Дата подписания документов продавцом
        /// </summary>
        public DateTime? SellerSignDate { get; set; }
        /// <summary>
        /// Дата подписания документов покупателем
        /// </summary>
        public DateTime? BuyerSignDate { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Сумма вознагрождения
        /// </summary>
        public decimal FullReward { get; set; }
        /// <summary>
        /// Сумма договора
        /// </summary>
        public decimal AgreementSum { get; set; }
        /// <summary>
        /// Номер депозита
        /// </summary>
        public string? DepositNumber { get; set; }
        /// <summary>
        /// Идентфикатор блокировки
        /// </summary>
        public long? BlockId { get; set; }
        /// <summary>
        /// Идентификатор депозита в учетной системе
        /// </summary>
        public string? ConcessionDepositId { get; set; }
        /// <summary>
        /// Комиссия банка
        /// </summary>
        public decimal CommissionOfTheBank { get; set; }
        /// <summary>
        /// Признак завершения взаиморасчетов
        /// </summary>
        public bool IsCreatePayment { get; set; }
        /// <summary>
        /// Дата создания изменения
        /// </summary>
        public DateTime HistoryDate { get; set; }
        /// <summary>
        /// Дата подписания
        /// </summary>
        public DateTime? SignDate { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual DepositAuctionLotStatus DepositAuctionLotStatus { get; set; } = null!;
    }
}
