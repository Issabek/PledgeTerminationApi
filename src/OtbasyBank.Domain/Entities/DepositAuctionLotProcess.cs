using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionLotProcess
    {
        public DepositAuctionLotProcess()
        {
            DepositAuctionLotStages = new HashSet<DepositAuctionLotStage>();
            DepositAuctionLots = new HashSet<DepositAuctionLot>();
        }

        /// <summary>
        /// ID записи
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Идентфикатор клиента
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Признак завершенности
        /// </summary>
        public bool Complited { get; set; }
        /// <summary>
        /// Наименование процесса
        /// </summary>
        public string? ProcessName { get; set; }
        /// <summary>
        /// Идентификатор депозита
        /// </summary>
        public string DepositId { get; set; } = null!;
        public int LotId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<DepositAuctionLotStage> DepositAuctionLotStages { get; set; }
        public virtual ICollection<DepositAuctionLot> DepositAuctionLots { get; set; }
    }
}
