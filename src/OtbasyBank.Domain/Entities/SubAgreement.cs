using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SubAgreement
    {
        public int Id { get; set; }
        public int LotId { get; set; }
        public string SubAgreementId { get; set; } = null!;
        public string SubAgreementNumber { get; set; } = null!;
        public DateTime SubAgreementDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
