using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PushStatus
    {
        public PushStatus()
        {
            PushNotifications = new HashSet<PushNotification>();
        }

        public string Id { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;

        public virtual ICollection<PushNotification> PushNotifications { get; set; }
    }
}
