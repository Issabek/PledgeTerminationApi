using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RoleOperation
    {
        public int RoleOperationId { get; set; }
        public string Module { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string? Description { get; set; }
        public int? ParentOperationId { get; set; }
    }
}
