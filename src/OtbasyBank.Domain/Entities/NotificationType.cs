using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class NotificationType
    {
        public NotificationType()
        {
            NotificationArchives = new HashSet<NotificationArchive>();
            Notifications = new HashSet<Notification>();
        }

        public string Id { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;

        public virtual ICollection<NotificationArchive> NotificationArchives { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
