using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientVerificationLog
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string Uuid { get; set; } = null!;
        public int? Stage { get; set; }
        public string? Data { get; set; }
        public string? Result { get; set; }
        public DateTime DateInserted { get; set; }
    }
}
