using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class TransferType
    {
        public TransferType()
        {
            MapKnpTransferTypes = new HashSet<MapKnpTransferType>();
            Transfers = new HashSet<Transfer>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public string Kbe { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<MapKnpTransferType> MapKnpTransferTypes { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
