using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Transfer
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public string TransferTypeId { get; set; } = null!;
        public decimal Amount { get; set; }
        public string SrcAccount { get; set; } = null!;
        public string TrgAccount { get; set; } = null!;
        public string? TrgName { get; set; }
        public string TrgIin { get; set; } = null!;
        public string? TrgPhone { get; set; }
        public string? TrgAltCode { get; set; }
        public DateTime DateCreated { get; set; }
        public string Kod { get; set; } = null!;
        public string Kbe { get; set; } = null!;
        public string Knp { get; set; } = null!;
        public string? Description { get; set; }
        public string? Reference { get; set; }
        public decimal Fee { get; set; }
        public string? FeeReference { get; set; }
        public string? ContractNum { get; set; }
        public DateTime? ContractDate { get; set; }
        public string? TariffColvirCode { get; set; }

        public virtual Request? Request { get; set; }
        public virtual TransferType TransferType { get; set; } = null!;
    }
}
