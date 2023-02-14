using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Device
    {
        public Device()
        {
            Bios = new HashSet<Bio>();
            Passcodes = new HashSet<Passcode>();
        }

        public int Id { get; set; }
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
        public string FrontEndId { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }
        public DateTime DateVerified { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Bio> Bios { get; set; }
        public virtual ICollection<Passcode> Passcodes { get; set; }
    }
}
