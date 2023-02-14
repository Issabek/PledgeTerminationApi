using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogOtpStageEnrollmentCrm
    {
        public int Id { get; set; }
        public string? Iin { get; set; }
        public string Name { get; set; } = null!;
        public string? Fam { get; set; }
        public string? Otch { get; set; }
        public string? MobilePhone { get; set; }
        public int CaseTarget { get; set; }
        public string? CaseOrigin { get; set; }
        public int? SntColvirDepCode { get; set; }
        public string? DopInfo { get; set; }
        public string? CrmResult { get; set; }
        public DateTime? CrmRequestDate { get; set; }
        public DateTime? CrmresponseDate { get; set; }
    }
}
