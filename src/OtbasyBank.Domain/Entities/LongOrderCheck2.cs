using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrderCheck2
    {
        public int Id { get; set; }
        public int LongOrderId { get; set; }
        public int StatusId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? Comment { get; set; }
        public string? ColverId { get; set; }
        public string? Exception { get; set; }

        public virtual LongOrder2 LongOrder { get; set; } = null!;
    }
}
