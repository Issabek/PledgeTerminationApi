using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionLotStage
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// ID процесса
        /// </summary>
        public long ProcessId { get; set; }
        /// <summary>
        /// Наименование нага
        /// </summary>
        public string StepName { get; set; } = null!;
        /// <summary>
        /// Дата показа формы
        /// </summary>
        public DateTime ShowDate { get; set; }
        /// <summary>
        /// Дата обработки формы
        /// </summary>
        public DateTime? PostedDate { get; set; }
        /// <summary>
        /// Отображаемая модель
        /// </summary>
        public string ShowModel { get; set; } = null!;
        /// <summary>
        /// Обрабатываемая модель
        /// </summary>
        public string? PostedModel { get; set; }

        public virtual DepositAuctionLotProcess Process { get; set; } = null!;
    }
}
