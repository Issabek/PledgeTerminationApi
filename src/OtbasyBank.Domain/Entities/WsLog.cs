using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class WsLog
    {
        public int Id { get; set; }
        public string WsName { get; set; } = null!;
        public DateTime LogDate { get; set; }
        public int? UserId { get; set; }
        public string? Data { get; set; }
        public string? InnerException { get; set; }
        public string? Message { get; set; }
        public string? Source { get; set; }
        public string? StackTrace { get; set; }
        public string? TargetSite { get; set; }
        public string? Parameters { get; set; }
    }
}
