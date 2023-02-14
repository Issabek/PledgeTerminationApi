using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LotStageProcessDeleted
    {
        public long Id { get; set; }
        public int ClientId { get; set; }
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
    }
}
