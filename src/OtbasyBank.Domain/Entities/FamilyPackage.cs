using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class FamilyPackage
    {
        public FamilyPackage()
        {
            Fpdeposits = new HashSet<Fpdeposit>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateDeactivated { get; set; }

        public virtual ICollection<Fpdeposit> Fpdeposits { get; set; }
    }
}
