using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RoleActionType
    {
        public int RoleActionTypeId { get; set; }
        public string Name { get; set; } = null!;
    }
}
