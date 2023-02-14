using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RoleOperationAction
    {
        public int RoleOperationActionId { get; set; }
        public int RoleOperationId { get; set; }
        public int RoleActionTypeId { get; set; }
        public int RoleAccessId { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Description { get; set; }
    }
}
