using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ViewForTest
    {
        public long UserId { get; set; }
        public string ClientIin { get; set; } = null!;
    }
}
