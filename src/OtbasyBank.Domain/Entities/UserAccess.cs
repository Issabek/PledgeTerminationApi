using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserAccess
    {
        public int UserAccessId { get; set; }
        public long UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string GivenBy { get; set; } = null!;
        public int? RoleAccessId { get; set; }
        public string? Description { get; set; }
        public string? CurrentJob { get; set; }
        public bool? IsTemporary { get; set; }
        public DateTime? EndDate { get; set; }
        public string? StandsInFor { get; set; }
        public string? Module { get; set; }

        public virtual RoleAccess? RoleAccess { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
