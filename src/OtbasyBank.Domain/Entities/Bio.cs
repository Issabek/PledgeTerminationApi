using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Bio
    {
        /// <summary>
        /// Идентификатор отпечатка
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус отпечатка
        /// </summary>
        public string BioStatusId { get; set; } = null!;
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public int DeviceId { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }

        public virtual Device Device { get; set; } = null!;
    }
}
