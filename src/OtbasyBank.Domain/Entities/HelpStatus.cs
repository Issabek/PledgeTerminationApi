using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HelpStatus
    {
        public HelpStatus()
        {
            Helps = new HashSet<Help>();
        }

        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public bool DoDisplay { get; set; }

        public virtual ICollection<Help> Helps { get; set; }
    }
}
