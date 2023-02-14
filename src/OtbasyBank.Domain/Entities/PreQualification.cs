using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PreQualification
    {
        public Guid PreQualificationId { get; set; }
        public Guid? PreQualificationBankId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string? PreQualificationData { get; set; }
        public int Status { get; set; }
        public long UserId { get; set; }
        public int PqType { get; set; }
        public string? PreQualificationSendBankToData { get; set; }
    }
}
