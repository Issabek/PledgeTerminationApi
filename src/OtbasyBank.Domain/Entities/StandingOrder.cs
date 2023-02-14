using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class StandingOrder
    {
        public StandingOrder()
        {
            StandingOrderProcesses = new HashSet<StandingOrderProcess>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Frequency { get; set; } = null!;
        public string Iban { get; set; } = null!;
        public string AlterCode { get; set; } = null!;
        public string AccountType { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reference { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string? Email { get; set; }
        public string Status { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? Type { get; set; }
        public Guid? Guid { get; set; }
        public string? CardId { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<StandingOrderProcess> StandingOrderProcesses { get; set; }
    }
}
