using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Draft
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = null!;
        public int ClientId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Body { get; set; } = null!;
    }
}
