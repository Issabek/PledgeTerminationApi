using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ChangeUserDataLog
    {
        public long Id { get; set; }
        public string Sender { get; set; } = null!;
        public DateTimeOffset DateUpdate { get; set; }
        public int Type { get; set; }
        public string ObjectDescriber { get; set; } = null!;
        public long UserId { get; set; }
        public string? Reason { get; set; }
    }
}
