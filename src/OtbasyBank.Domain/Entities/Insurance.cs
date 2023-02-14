using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Insurance
    {
        public int Id { get; set; }
        public string ClientId { get; set; } = null!;
        public string LoanId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Xml { get; set; } = null!;
        public string? SendDataXml { get; set; }
        public int? RequestId { get; set; }
    }
}
