using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PreQualificationStage
    {
        public long PreQualificationStageId { get; set; }
        public Guid PreQualificationId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string StageNum { get; set; } = null!;
        public string PreQualificationStageData { get; set; } = null!;
        public string? CurrentStage { get; set; }
    }
}
