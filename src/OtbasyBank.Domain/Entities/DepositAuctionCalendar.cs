using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionCalendar
    {
        /// <summary>
        /// ID записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Дата завершения
        /// </summary>
        public DateTime ToDate { get; set; }
        /// <summary>
        /// Причина запрета торгов
        /// </summary>
        public string? Reason { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
