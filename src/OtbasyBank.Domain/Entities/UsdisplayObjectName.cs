using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UsdisplayObjectName
    {
        public int Id { get; set; }
        public string DisplayId { get; set; } = null!;
        public int TypeId { get; set; }
        public string? OldName { get; set; }
        public string NewName { get; set; } = null!;
        public DateTime LastUpdateDate { get; set; }
    }
}
