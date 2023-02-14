using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class EgovResponse
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string? Response { get; set; }
        public DateTime Date { get; set; }
        public string Phone { get; set; } = null!;
    }
}
