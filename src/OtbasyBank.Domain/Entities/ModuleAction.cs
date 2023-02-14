using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ModuleAction
    {
        public ModuleAction()
        {
            RoleModules = new HashSet<RoleModule>();
        }

        public int ModuleActionId { get; set; }
        public string Name { get; set; } = null!;
        public int ModuleId { get; set; }
        public string MethodType { get; set; } = null!;

        public virtual Module Module { get; set; } = null!;
        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
