using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Knp
    {
        public Knp()
        {
            MapKnpTransferTypes = new HashSet<MapKnpTransferType>();
        }

        public string Id { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;

        public virtual ICollection<MapKnpTransferType> MapKnpTransferTypes { get; set; }
    }
}
