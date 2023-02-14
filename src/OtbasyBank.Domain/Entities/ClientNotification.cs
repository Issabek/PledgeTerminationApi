using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientNotification
    {
        public int ClientId { get; set; }
        public long NotificationId { get; set; }
        public string StatusId { get; set; } = null!;
        public DateTime StatusDate { get; set; }
        public long ClientNotificationId { get; set; }
        public string? ColvirReferenceId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ClientNotificationStatus Status { get; set; } = null!;
    }
}
