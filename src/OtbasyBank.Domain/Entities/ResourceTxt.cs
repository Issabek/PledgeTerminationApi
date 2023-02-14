using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ResourceTxt
    {
        public int Id { get; set; }
        public string KeyTxt { get; set; } = null!;
        public string ValueRu { get; set; } = null!;
        public string ValueKz { get; set; } = null!;
    }
}
