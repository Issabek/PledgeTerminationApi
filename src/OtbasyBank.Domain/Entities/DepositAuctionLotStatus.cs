using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionLotStatus
    {
        public DepositAuctionLotStatus()
        {
            DepositAuctionLotHistories = new HashSet<DepositAuctionLotHistory>();
            DepositAuctionLots = new HashSet<DepositAuctionLot>();
        }

        /// <summary>
        /// ID статуса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование статуса
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Признак отказа
        /// </summary>
        public bool IsCanceled { get; set; }
        /// <summary>
        /// Признак завершения
        /// </summary>
        public bool IsComplited { get; set; }
        /// <summary>
        /// Признак процесса
        /// </summary>
        public bool InProcess { get; set; }

        public virtual ICollection<DepositAuctionLotHistory> DepositAuctionLotHistories { get; set; }
        public virtual ICollection<DepositAuctionLot> DepositAuctionLots { get; set; }
    }
}
