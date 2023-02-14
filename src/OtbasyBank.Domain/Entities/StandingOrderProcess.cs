using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class StandingOrderProcess
    {
        public StandingOrderProcess()
        {
            StandingOrderStages = new HashSet<StandingOrderStage>();
        }

        public long ProcessId { get; set; }
        public int StandingOrderId { get; set; }
        public long? OrderId { get; set; }
        public int? AtmStan { get; set; }
        public string? AtmRrn { get; set; }
        public int Attempt { get; set; }
        public string ProcessStatus { get; set; } = null!;
        public DateTime? ProcessStatusDate { get; set; }
        public string? EpayStatus { get; set; }
        public DateTime? EpayStatusDate { get; set; }
        public string? AtmStatus { get; set; }
        public DateTime? AtmStatusDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid LogProcessId { get; set; }

        public virtual StandingOrder StandingOrder { get; set; } = null!;
        public virtual ICollection<StandingOrderStage> StandingOrderStages { get; set; }
    }
}
