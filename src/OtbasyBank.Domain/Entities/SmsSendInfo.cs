using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SmsSendInfo
    {
        public int Id { get; set; }
        public string? RegNum { get; set; }
        public int OperationId { get; set; }
        public int OtpId { get; set; }
        public string Phone { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime SendDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; } = null!;
        /// <summary>
        /// Запрос
        /// </summary>
        public string? RequestData { get; set; }
        /// <summary>
        /// Ответ
        /// </summary>
        public string? ResponseData { get; set; }
    }
}
