using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HelpTopic
    {
        public HelpTopic()
        {
            Helps = new HashSet<Help>();
        }

        public string Id { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public int Priority { get; set; }

        public virtual ICollection<Help> Helps { get; set; }
    }
}
