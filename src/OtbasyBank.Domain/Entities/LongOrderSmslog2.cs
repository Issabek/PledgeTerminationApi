using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrderSmslog2
    {
        public int Id { get; set; }
        public string? ClientIin { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientPhone { get; set; }
        public int? UserId { get; set; }
        public string? Response { get; set; }
        public DateTime? InsertDateTime { get; set; }
    }
}
