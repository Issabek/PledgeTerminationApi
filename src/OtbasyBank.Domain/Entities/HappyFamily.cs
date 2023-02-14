using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HappyFamily
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? SurName { get; set; }
        public string? FirstName { get; set; }
        public string? DadName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? QueuedDate { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? AdrObl { get; set; }
        public string? AdrReg { get; set; }
        public string? Adress { get; set; }
        public string? Contact { get; set; }
        public DateTime? RequestDate { get; set; }
        public bool? Accept { get; set; }
        public bool? IsSended { get; set; }
        public DateTime? SendCrmDate { get; set; }
        public Guid? CrmResponse { get; set; }
    }
}
