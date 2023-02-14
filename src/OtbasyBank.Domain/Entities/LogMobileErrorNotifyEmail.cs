using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogMobileErrorNotifyEmail
    {
        public int Id { get; set; }
        public int ErrorId { get; set; }
        public int? IsUsed { get; set; }

        public virtual LogMobileErrorInfo Error { get; set; } = null!;
    }
}
