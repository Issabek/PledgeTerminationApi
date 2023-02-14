using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LoanStatus
    {
        public LoanStatus()
        {
            LoanTechStatuses = new HashSet<LoanTechStatus>();
        }

        public int Id { get; set; }
        public string TitleRu { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public int Ordinal { get; set; }
        public bool? IsPositive { get; set; }

        public virtual ICollection<LoanTechStatus> LoanTechStatuses { get; set; }
    }
}
