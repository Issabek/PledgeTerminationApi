using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Passcode
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Статус кода
        /// </summary>
        public string PasscodeStatusId { get; set; } = null!;
        /// <summary>
        /// Хэш кода
        /// </summary>
        public byte[] Hash { get; set; } = null!;
        /// <summary>
        /// Соль
        /// </summary>
        public Guid Salt { get; set; }
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
