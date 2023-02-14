using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InfobipToken
    {
        public int Id { get; set; }
        public string Token { get; set; } = null!;
        public int DeviceId { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; } = null!;
    }
}
