using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ArhiveUserLogin
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string UserLogin { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public DateTime? UserLastLoginDate { get; set; }
        public DateTime? UserLastPassChangeDate { get; set; }
        public DateTime? UserLastLockOutDate { get; set; }
        public int UserFailedPasswordAttemptCount { get; set; }
        public int UserType { get; set; }
        public string? UserEmail { get; set; }
        public int Status { get; set; }
        public DateTime UserCreateDate { get; set; }
        public DateTime UserFailedPasswordAttemptWindowStart { get; set; }
        public DateTime CreateDate { get; set; }
        public int ArhiveType { get; set; }
    }
}
