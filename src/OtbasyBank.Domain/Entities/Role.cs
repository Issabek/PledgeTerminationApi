using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            RoleModules = new HashSet<RoleModule>();
        }

        /// <summary>
        /// role_id идентифицирует Роли пользователей системы
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// status относится к Роли пользователей системы
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// name относится к Роли пользователей системы
        /// </summary>
        public string? Name { get; set; }
        public int UserType { get; set; }

        public virtual ICollection<RoleModule> RoleModules { get; set; }
    }
}
