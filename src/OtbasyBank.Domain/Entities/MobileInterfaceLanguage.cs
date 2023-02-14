using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MobileInterfaceLanguage
    {
        public long UserId { get; set; }
        public string UserLogin { get; set; } = null!;
        public string ClientIin { get; set; } = null!;
        public string? UserLanguage { get; set; }
        public DateTime Date { get; set; }
    }
}
