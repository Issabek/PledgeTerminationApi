using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositOperation
    {
        public Guid DepositOperationId { get; set; }
        public Guid? DepositOperationBankId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string? DepositOperationData { get; set; }
        public int Status { get; set; }
        public long UserId { get; set; }
        public int DoType { get; set; }
    }
}
