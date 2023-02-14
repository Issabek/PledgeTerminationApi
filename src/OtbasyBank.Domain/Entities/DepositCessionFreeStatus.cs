using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositCessionFreeStatus
    {
        public int StatusCode { get; set; }
        public string? StatusName { get; set; }
        public string? Comments { get; set; }
    }
}
