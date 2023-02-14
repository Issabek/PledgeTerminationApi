using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PnToken
    {
        public long UserId { get; set; }
        public string TokenId { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
