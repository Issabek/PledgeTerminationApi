using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RoleAccess
    {
        public RoleAccess()
        {
            UserAccesses = new HashSet<UserAccess>();
        }

        public int RoleAccessId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public int SystemId { get; set; }

        public virtual ICollection<UserAccess> UserAccesses { get; set; }
    }
}
