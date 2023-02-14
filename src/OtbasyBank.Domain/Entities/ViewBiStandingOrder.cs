using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ViewBiStandingOrder
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal Amount { get; set; }
        public string AlterCode { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
