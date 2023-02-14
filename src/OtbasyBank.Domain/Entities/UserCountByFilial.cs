using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserCountByFilial
    {
        public string? CbsOblCode { get; set; }
        public int? RegCount { get; set; }
        public int? ActiveCount { get; set; }
        public int? YearValue { get; set; }
        public string? MonthValue { get; set; }
    }
}
