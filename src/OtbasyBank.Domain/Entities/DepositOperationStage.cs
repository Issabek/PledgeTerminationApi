using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositOperationStage
    {
        public long DepositOperationStageId { get; set; }
        public Guid DepositOperationId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string StageNum { get; set; } = null!;
        public string DepositOperationStageData { get; set; } = null!;
        public string? CurrentStage { get; set; }
    }
}
