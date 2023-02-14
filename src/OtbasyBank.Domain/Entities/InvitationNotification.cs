using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InvitationNotification
    {
        public int Id { get; set; }
        public long ClientNotificationId { get; set; }
        public int FpdepositId { get; set; }

        public virtual Fpdeposit Fpdeposit { get; set; } = null!;
    }
}
