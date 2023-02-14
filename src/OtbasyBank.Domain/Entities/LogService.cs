using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogService
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Level { get; set; } = null!;
        public string Line { get; set; } = null!;
        public string Method { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Message { get; set; }
        public string? Exception { get; set; }
    }
}
