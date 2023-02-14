using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InfobipTokenHistory
    {
        public int Id { get; set; }
        public int InfobipTokenId { get; set; }
        public string Token { get; set; } = null!;
        public int DeviceId { get; set; }
        public DateTime Changed { get; set; }
        public string Status { get; set; } = null!;
    }
}
