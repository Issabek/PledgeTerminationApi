using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class PreQualificationReply
    {
        public long PreQualificationReplyId { get; set; }
        public Guid PreQualificationBankId { get; set; }
        public int Status { get; set; }
        public string? PreQualificationReply1 { get; set; }
    }
}
