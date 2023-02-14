using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class CorporateTarifEmployee
    {
        public int Id { get; set; }
        public Guid CompanyGuid { get; set; }
        public string? Fio { get; set; }
        public string? Iin { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Position { get; set; }
        public string? InsertUser { get; set; }
        public DateTime? InsertDateTime { get; set; }
        public decimal? Rate { get; set; }
    }
}
