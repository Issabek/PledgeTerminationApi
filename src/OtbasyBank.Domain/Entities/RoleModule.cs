using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    /// <summary>
    /// Модули ролей (сами модули в проекте)
    /// </summary>
    public partial class RoleModule
    {
        public int RoleModuleId { get; set; }
        /// <summary>
        /// id роли
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// id действия модуля
        /// </summary>
        public int ModuleActionId { get; set; }
        public int? ModuleActionDivisionParamType { get; set; }
        /// <summary>
        /// параметр для действия модуля
        /// </summary>
        public int? ModuleActionParameter { get; set; }

        public virtual ModuleAction ModuleAction { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
