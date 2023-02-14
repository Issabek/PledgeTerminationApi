using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class News
    {
        public int Id { get; set; }
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string BodyKk { get; set; } = null!;
        public string BodyRu { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string StatusId { get; set; } = null!;
        public DateTime StatusDate { get; set; }

        public virtual NewsStatus Status { get; set; } = null!;
    }
}
