using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RssNews
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string Lang { get; set; } = null!;
        public DateTime? PubDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string StatusId { get; set; } = null!;
        public DateTime StatusDate { get; set; }

        public virtual NewsStatus Status { get; set; } = null!;
    }
}
