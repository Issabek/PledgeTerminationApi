using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ListClientNotMobileApp
    {
        public long UserId { get; set; }
        public string UserLogin { get; set; } = null!;
    }
}
