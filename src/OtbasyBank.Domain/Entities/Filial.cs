using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Filial
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? CbsOblCode { get; set; }
        public string? CbsOblName { get; set; }
    }
}
