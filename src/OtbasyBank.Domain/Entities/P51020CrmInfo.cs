using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class P51020CrmInfo
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Iin { get; set; } = null!;
        public bool Send { get; set; }
        public int TryCount { get; set; }
        public string? Exception { get; set; }
        public DateTime LastTryDate { get; set; }
        public string Url { get; set; } = null!;
        public string Query { get; set; } = null!;
    }
}
