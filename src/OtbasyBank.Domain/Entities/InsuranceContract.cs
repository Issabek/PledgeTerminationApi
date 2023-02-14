using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class InsuranceContract
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public string Type { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Amount { get; set; }
        public decimal Premium { get; set; }
        public string? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Bic { get; set; }
        public string? Iban { get; set; }
        public string? Kbe { get; set; }
        public string? Bin { get; set; }
        public string? ContractNo { get; set; }
        public string? TransferDesc { get; set; }
        public string? TransferReference { get; set; }
        public string? SendDataInsurId { get; set; }
        public string? CustomerIban { get; set; }
    }
}
