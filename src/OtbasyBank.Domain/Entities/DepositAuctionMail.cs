using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositAuctionMail
    {
        /// <summary>
        /// Идентфикатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентфикатор лота
        /// </summary>
        public int LotId { get; set; }
        /// <summary>
        /// Кому отправить
        /// </summary>
        public string To { get; set; } = null!;
        /// <summary>
        /// Тема письма
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// Содержимое письма
        /// </summary>
        public string Body { get; set; } = null!;
        /// <summary>
        /// Вложение
        /// </summary>
        public byte[]? Attachment { get; set; }
        /// <summary>
        /// Наименовние вложения
        /// </summary>
        public string? AttachmentName { get; set; }
        /// <summary>
        /// Статус отправки письма
        /// </summary>
        public int SendStatus { get; set; }
        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime? SendDate { get; set; }

        public virtual DepositAuctionLot Lot { get; set; } = null!;
    }
}
