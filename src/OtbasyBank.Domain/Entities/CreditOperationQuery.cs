using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class CreditOperationQuery
    {
        public long CreditOperationQueryId { get; set; }
        public string SessionId { get; set; } = null!;
        public string TokenId { get; set; } = null!;
        public string XmlData { get; set; } = null!;
        public string? BankAnswer { get; set; }
        public int CoType { get; set; }
        public int Status { get; set; }
        public Guid CreditOperationId { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public DateTime? Updated { get; set; }
        public string? BankComment { get; set; }
    }
}
