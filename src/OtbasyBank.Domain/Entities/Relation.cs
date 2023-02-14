using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Relation
    {
        public Relation()
        {
            Fpdeposits = new HashSet<Fpdeposit>();
        }

        public string Id { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public int? Priority { get; set; }

        public virtual ICollection<Fpdeposit> Fpdeposits { get; set; }
    }
}
