using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LoanTechStatus
    {
        public string Id { get; set; } = null!;
        public int LoanStatusId { get; set; }

        public virtual LoanStatus LoanStatus { get; set; } = null!;
    }
}
