using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class CreditOperation
    {
        public Guid CreditOperationId { get; set; }
        public Guid? CreditOperationBankId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string? CreditOperationData { get; set; }
        public int Status { get; set; }
        public long UserId { get; set; }
        public int CoType { get; set; }
        public string CreditId { get; set; } = null!;
    }
}
