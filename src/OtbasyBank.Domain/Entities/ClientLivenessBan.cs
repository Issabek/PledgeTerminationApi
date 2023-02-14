using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientLivenessBan
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string? Process { get; set; }
        public decimal? FraudPercentage { get; set; }
        public DateTime? ProcessTimde { get; set; }
    }
}
