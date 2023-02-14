using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class FpdepositStatus
    {
        public FpdepositStatus()
        {
            Fpdeposits = new HashSet<Fpdeposit>();
        }

        public string Id { get; set; } = null!;
        public bool IsLinked { get; set; }
        public string? MessageToInitiatorRu { get; set; }
        public string? MessageToIviteeRu { get; set; }
        public string? MessageToInitiatorKk { get; set; }
        public string? MessageToIviteeKk { get; set; }

        public virtual ICollection<Fpdeposit> Fpdeposits { get; set; }
    }
}
