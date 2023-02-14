using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class GetLogErrorLogWithArhView
    {
        public int Id { get; set; }
        public string? ErrorType { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public string? UserLogin { get; set; }
        public string? Ip { get; set; }
        public string? Browser { get; set; }
        public string? Url { get; set; }
        public string? Password { get; set; }
        public string? ErrorGuid { get; set; }
        public string? ExSource { get; set; }
        public string? ExMessage { get; set; }
        public string? ExNamespace { get; set; }
        public string? ExMethod { get; set; }
        public string? ExComputer { get; set; }
        public string? ExError { get; set; }
        public string? ExInnerException { get; set; }
        public string? ExStackTrace { get; set; }
    }
}
