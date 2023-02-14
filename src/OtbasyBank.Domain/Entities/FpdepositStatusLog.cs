using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class FpdepositStatusLog
    {
        public int Id { get; set; }
        public int FpdepositId { get; set; }
        public string StatusId { get; set; } = null!;
        public DateTime StatusDate { get; set; }

        public virtual Fpdeposit Fpdeposit { get; set; } = null!;
    }
}
