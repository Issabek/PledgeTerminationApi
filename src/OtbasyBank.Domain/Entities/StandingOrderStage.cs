using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class StandingOrderStage
    {
        public long StageId { get; set; }
        public long ProcessId { get; set; }
        public string StageName { get; set; } = null!;
        public DateTime SendDate { get; set; }
        public string SendData { get; set; } = null!;
        public DateTime? ReceivedDate { get; set; }
        public string? ReceivedData { get; set; }
        public bool HasError { get; set; }

        public virtual StandingOrderProcess Process { get; set; } = null!;
    }
}
