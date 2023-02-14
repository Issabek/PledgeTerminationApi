using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Module
    {
        public Module()
        {
            ModuleActions = new HashSet<ModuleAction>();
        }

        public int ModuleId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ModuleAction> ModuleActions { get; set; }
    }
}
