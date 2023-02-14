using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class CreditOperationStage
    {
        public long CreditOperationStageId { get; set; }
        public Guid CreditOperationId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string StageNum { get; set; } = null!;
        public string CreditOperationStageData { get; set; } = null!;
        public string? CurrentStage { get; set; }
    }
}
