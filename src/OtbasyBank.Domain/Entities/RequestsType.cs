using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RequestsType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Actual { get; set; }
        public string Type { get; set; } = null!;
        public string? NameKz { get; set; }
    }
}
