using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HistoryAction
    {
        public int UserId { get; set; }
        public string? ClientCode { get; set; }
        public string? UserIp { get; set; }
        public int? ActionType { get; set; }
        public string? Dep { get; set; }
        public string? ActionTypeName { get; set; }
        public DateTime? Data { get; set; }
        public string? SystemName { get; set; }
    }
}
