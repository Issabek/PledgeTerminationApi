using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InsuranceStatus
    {
        public string Id { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public bool IsFinal { get; set; }
        public bool IsIgnored { get; set; }
    }
}
