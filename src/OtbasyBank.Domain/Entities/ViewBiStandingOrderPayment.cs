using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ViewBiStandingOrderPayment
    {
        public int StandingOrderId { get; set; }
        public string ClientIin { get; set; } = null!;
        public string ClientCode { get; set; } = null!;
        public string? Fio { get; set; }
        public decimal Amount { get; set; }
        public string AlterCode { get; set; } = null!;
        public string Iban { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
