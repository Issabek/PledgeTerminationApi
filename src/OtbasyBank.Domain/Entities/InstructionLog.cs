using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InstructionLog
    {
        public int Id { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public string? Comment { get; set; }
        public string? Folder { get; set; }
        public string Operation { get; set; } = null!;
    }
}
