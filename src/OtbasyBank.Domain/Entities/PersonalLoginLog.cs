using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PersonalLoginLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
