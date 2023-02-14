using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HsTransactionLog
    {
        public string GlobalTranId { get; set; } = null!;
        public string? TranComment { get; set; }
    }
}
