using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Fpdeposit
    {
        public Fpdeposit()
        {
            FpdepositStatusLogs = new HashSet<FpdepositStatusLog>();
            InvitationNotifications = new HashSet<InvitationNotification>();
        }

        public int Id { get; set; }
        public string AlterCode { get; set; } = null!;
        public string Iban { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public int ClientId { get; set; }
        public int FamilyPackageId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime StatusDate { get; set; }
        public string Relation { get; set; } = null!;
        public string Refer { get; set; } = null!;

        public virtual FamilyPackage FamilyPackage { get; set; } = null!;
        public virtual Relation RelationNavigation { get; set; } = null!;
        public virtual FpdepositStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<FpdepositStatusLog> FpdepositStatusLogs { get; set; }
        public virtual ICollection<InvitationNotification> InvitationNotifications { get; set; }
    }
}
