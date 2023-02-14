using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogMobileErrorInfoRequest
    {
        public string? Guid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? RequestContext { get; set; }
    }
}
