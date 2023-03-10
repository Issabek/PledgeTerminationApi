using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrderFiles2
    {
        public int Id { get; set; }
        public int LongOrderId { get; set; }
        public byte[] File { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileContentType { get; set; } = null!;
        public string? ClientCode { get; set; }

        public virtual LongOrder2 LongOrder { get; set; } = null!;
    }
}
