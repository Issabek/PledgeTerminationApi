using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientRestrictionsAndDelayLog
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public string? ObjectId { get; set; }
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
