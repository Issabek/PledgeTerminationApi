using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositOperationLink
    {
        public Guid DepositOperationId { get; set; }
        public string DepositId { get; set; } = null!;
        public int Id { get; set; }
    }
}
