using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MioErrorLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Iin { get; set; }
        public string? Method { get; set; }
        public string? Message { get; set; }
        public string? Error { get; set; }
        public string? InnerException { get; set; }
        public string? StackTrace { get; set; }
    }
}
