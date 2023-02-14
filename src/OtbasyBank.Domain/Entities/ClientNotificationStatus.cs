using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientNotificationStatus
    {
        public ClientNotificationStatus()
        {
            ClientNotifications = new HashSet<ClientNotification>();
        }

        public string Id { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public bool DoDisplay { get; set; }

        public virtual ICollection<ClientNotification> ClientNotifications { get; set; }
    }
}
