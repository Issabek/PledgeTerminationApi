using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionBidProcess
    {
        public DepositAuctionBidProcess()
        {
            DepositAuctionBidStages = new HashSet<DepositAuctionBidStage>();
            DepositAuctionBids = new HashSet<DepositAuctionBid>();
        }

        public long Id { get; set; }
        /// <summary>
        /// ID клиента
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
        /// Идентификатор лота
        /// </summary>
        public int LotId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<DepositAuctionBidStage> DepositAuctionBidStages { get; set; }
        public virtual ICollection<DepositAuctionBid> DepositAuctionBids { get; set; }
    }
}
