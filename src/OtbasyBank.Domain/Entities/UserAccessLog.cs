using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserAccessLog
    {
        public int UserAccessLogId { get; set; }
        public int UserId { get; set; }
        public string UserLogin { get; set; } = null!;
        public string RoleCode { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public string GivenBy { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public string? CurrentJob { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
