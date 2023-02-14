using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DevinoLog
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime? StartDate { get; set; }
    }
}
