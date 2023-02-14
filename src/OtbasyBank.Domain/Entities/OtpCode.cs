using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class OtpCode
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? OtpCode1 { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
