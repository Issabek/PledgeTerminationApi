using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MilitaryHoldOverUser
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string? Fio { get; set; }
        public int UserId { get; set; }
        public int Month { get; set; }
    }
}
