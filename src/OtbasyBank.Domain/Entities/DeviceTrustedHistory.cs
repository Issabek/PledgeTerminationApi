using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DeviceTrustedHistory
    {
        public long Id { get; set; }
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public string DeviceId { get; set; } = null!;
        /// <summary>
        /// ID пользователя
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// Идентификатор фронта
        /// </summary>
        public string? FrontEndId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }
        public bool Trusted { get; set; }
    }
}
