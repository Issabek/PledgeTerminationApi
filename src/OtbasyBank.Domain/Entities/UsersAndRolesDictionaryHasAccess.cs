using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UsersAndRolesDictionaryHasAccess
    {
        public string UserLogin { get; set; } = null!;
        public int UserAccessId { get; set; }
        public int RoleOperationId { get; set; }
        public int RoleActionTypeId { get; set; }
        public string Module { get; set; } = null!;
    }
}
