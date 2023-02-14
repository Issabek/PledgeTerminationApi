using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SmsSendLog
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Запрос
        /// </summary>
        public string RequestData { get; set; } = null!;
        /// <summary>
        /// Ответ
        /// </summary>
        public string ResponseData { get; set; } = null!;
        public int UserId { get; set; }
        public string? UserIin { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Module { get; set; }
        public bool? Status { get; set; }
        public string? TypeSystem { get; set; }
    }
}
