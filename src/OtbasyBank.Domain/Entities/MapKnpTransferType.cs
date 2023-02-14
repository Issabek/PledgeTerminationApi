using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MapKnpTransferType
    {
        public string KnpId { get; set; } = null!;
        public string TransferTypeId { get; set; } = null!;
        public int? Priority { get; set; }

        public virtual Knp Knp { get; set; } = null!;
        public virtual TransferType TransferType { get; set; } = null!;
    }
}
