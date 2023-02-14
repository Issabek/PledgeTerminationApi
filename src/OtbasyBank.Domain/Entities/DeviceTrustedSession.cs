using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DeviceTrustedSession
    {
        public long Id { get; set; }
        public string DeviceId { get; set; } = null!;
        public long UserId { get; set; }
        public string SessionId { get; set; } = null!;
        public DateTime DateCreate { get; set; }
    }
}
