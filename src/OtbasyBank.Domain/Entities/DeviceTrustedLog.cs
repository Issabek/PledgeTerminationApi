using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DeviceTrustedLog
    {
        public long Id { get; set; }
        public string DeviceId { get; set; } = null!;
        public long UserId { get; set; }
        public bool Trusted { get; set; }
        public string? Device { get; set; }
        public string? Manufacturer { get; set; }
        public string? DeviceName { get; set; }
        public string? VersionName { get; set; }
        public string? PlatformName { get; set; }
        public string? Idiom { get; set; }
        public string? DeviceType { get; set; }
        public string? CurrentVersion { get; set; }
        public string? CurrentBuild { get; set; }
        public DateTime DateCreate { get; set; }
        public string? SessionId { get; set; }
    }
}
