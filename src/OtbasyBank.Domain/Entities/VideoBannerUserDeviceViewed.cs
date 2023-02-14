using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class VideoBannerUserDeviceViewed
    {
        public string DeviceId { get; set; } = null!;
        public int UserId { get; set; }
        public int VideoBannerId { get; set; }
        public DateTime? DateViewed { get; set; }
    }
}
