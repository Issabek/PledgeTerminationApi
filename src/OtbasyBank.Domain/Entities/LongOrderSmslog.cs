using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrderSmslog
    {
        public int Id { get; set; }
        public Guid? LongOrderGuid { get; set; }
        public string? ClientPhone { get; set; }
        public string? Response { get; set; }
        public string? Text { get; set; }
        public DateTime? InsertDateTime { get; set; }
    }
}
