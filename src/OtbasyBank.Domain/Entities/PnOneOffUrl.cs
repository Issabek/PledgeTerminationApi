using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PnOneOffUrl
    {
        public long UserId { get; set; }
        public string TokenId { get; set; } = null!;
        public DateTime Created { get; set; }
        public int UrlType { get; set; }
        public int Status { get; set; }
        public Guid UrlGuid { get; set; }
    }
}
