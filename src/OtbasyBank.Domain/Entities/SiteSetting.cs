using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SiteSetting
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
