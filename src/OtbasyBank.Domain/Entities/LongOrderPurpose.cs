using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrderPurpose
    {
        public LongOrderPurpose()
        {
            LongOrder2s = new HashSet<LongOrder2>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<LongOrder2> LongOrder2s { get; set; }
    }
}
