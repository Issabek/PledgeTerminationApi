using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string NameRu { get; set; } = null!;
        public string NameKz { get; set; } = null!;
        public string? TextRu { get; set; }
        public string? TextKz { get; set; }
        public int Actual { get; set; }
        public int Parentid { get; set; }
        public int? OrderNum { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
    }
}
