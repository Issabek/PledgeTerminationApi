using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UsdisplayObjectGoal
    {
        public int Id { get; set; }
        public string DisplayId { get; set; } = null!;
        public int TypeId { get; set; }
        public string Goal { get; set; } = null!;
        public DateTime LastUpdateDate { get; set; }
    }
}
