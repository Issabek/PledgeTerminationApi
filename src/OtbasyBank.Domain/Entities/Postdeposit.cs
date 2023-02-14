using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Postdeposit
    {
        public long Id { get; set; }
        public string? Otp { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserLogin { get; set; } = null!;
        public string? Certificate { get; set; }
        public string? AgreementWithOtp { get; set; }
        public string? AgreementWithoutOtp { get; set; }
        public bool AgreementReady { get; set; }
        public bool CertificateReady { get; set; }
        public int? UserId { get; set; }
        public bool AcceptOtp { get; set; }
        public short Stage { get; set; }
    }
}
