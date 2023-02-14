using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ArhiveClientInfo
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientCode { get; set; } = null!;
        public string ClientId1 { get; set; } = null!;
        public string ClientIin { get; set; } = null!;
        public long UserId { get; set; }
    }
}
