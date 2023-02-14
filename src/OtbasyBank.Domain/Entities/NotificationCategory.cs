using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class NotificationCategory
    {
        public long Id { get; set; }
        public string CrmId { get; set; } = null!;
        public string NameKk { get; set; } = null!;
        public string NameRu { get; set; } = null!;
        public byte[]? ImgData { get; set; }
        public string LightModeBg { get; set; } = null!;
        public string DarkModeBg { get; set; } = null!;
        public bool? Actual { get; set; }
        public int? Ord { get; set; }
    }
}
