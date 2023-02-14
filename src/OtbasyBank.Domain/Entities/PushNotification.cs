using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PushNotification
    {
        public long PushId { get; set; }
        public long ClientNotificationId { get; set; }
        public string PushStatusId { get; set; } = null!;
        public DateTime DatetimeCreate { get; set; }
        public int Attempts { get; set; }
        public DateTime? LastAttempt { get; set; }

        public virtual PushStatus PushStatus { get; set; } = null!;
    }
}
