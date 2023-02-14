using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionFormsAndSm
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ValueKaz { get; set; }
    }
}
