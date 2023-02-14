using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogOtpStageEnrollment
    {
        public string? Operation { get; set; }
        public string ClientIin { get; set; } = null!;
        public string ClientLogin { get; set; } = null!;
        public DateTime? CreateDate { get; set; }
        public string? CrmResult { get; set; }
    }
}
