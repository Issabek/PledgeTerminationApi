using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositCessionFreeLog
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public int? CessionId { get; set; }
        public string? SourceName { get; set; }
        public string? MethodName { get; set; }
        public string? InputParameters { get; set; }
        public string? Result { get; set; }
        public DateTime? CallTime { get; set; }
        public DateTime? ResponseTime { get; set; }
        public string? ResultCode { get; set; }
        public string? Comment { get; set; }
    }
}
