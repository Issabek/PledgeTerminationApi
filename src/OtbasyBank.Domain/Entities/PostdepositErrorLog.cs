using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PostdepositErrorLog
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string? User { get; set; }
        public string? Method { get; set; }
        public string? Message { get; set; }
        public string? Error { get; set; }
        public string? InnerException { get; set; }
        public string? StackTrace { get; set; }
        public long? PostdepositId { get; set; }
        public int? UserId { get; set; }
    }
}
