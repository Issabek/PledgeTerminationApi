using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ChangerequisitesLogsTwo
    {
        public int Id { get; set; }
        public string? UserIin { get; set; }
        public string? Message { get; set; }
        public string? Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Exception { get; set; }
        public string? StackTrace { get; set; }
        public string? ExInnerMessage { get; set; }
        public string? ExInnerStackTrace { get; set; }
    }
}
