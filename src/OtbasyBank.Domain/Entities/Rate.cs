using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Rate
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public int Points { get; set; }
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Request? Request { get; set; }
    }
}
