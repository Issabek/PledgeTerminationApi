using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InsuranceProcess
    {
        public int ProcessId { get; set; }
        public Guid LogProcessId { get; set; }
        public int InsuranceId { get; set; }
        public int Attempt { get; set; }
        public DateTime CreateDate { get; set; }
        public string? SendDataResult { get; set; }
        public DateTime? SendDataDate { get; set; }
        public string? PaymentReferenceP { get; set; }
        public string? PaymentReferenceT { get; set; }
        public DateTime? PaymentDateP { get; set; }
        public DateTime? PaymentDateT { get; set; }
        public string? SendFileResultP { get; set; }
        public string? SendFileResultT { get; set; }
        public DateTime? SendFileDateP { get; set; }
        public DateTime? SendFileDateT { get; set; }
        public string? CreateInsuranceAgreementP { get; set; }
        public DateTime? CreateInsuranceAgreementDateP { get; set; }
        public string? CreateInsuranceAgreementT { get; set; }
        public DateTime? CreateInsuranceAgreementDateT { get; set; }
        public string? ResultPaymentCodeT { get; set; }
        public string? ResultPaymentCodeP { get; set; }
        public bool? IsPaidT { get; set; }
        public bool? IsPaidP { get; set; }
    }
}
