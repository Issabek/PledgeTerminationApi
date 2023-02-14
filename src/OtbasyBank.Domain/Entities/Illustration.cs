using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Illustration
    {
        public int Id { get; set; }
        public string RefType { get; set; } = null!;
        public int RefId { get; set; }
        public string Size { get; set; } = null!;
        public string Ext { get; set; } = null!;
        public int Priority { get; set; }
        public byte[]? Binary { get; set; }
    }
}
