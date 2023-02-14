using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrder
    {
        public LongOrder()
        {
            LongOrderFiles = new HashSet<LongOrderFile>();
        }

        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public string SenderIin { get; set; } = null!;
        public int DepId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Amount { get; set; }
        public int OrderTypeId { get; set; }
        public string SpecAccountCode { get; set; } = null!;
        public string BenClientCode { get; set; } = null!;
        public string BenAccountCode { get; set; } = null!;
        public int PayDay { get; set; }
        public int? ParsId { get; set; }
        public string Knp { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public string Kbe { get; set; } = null!;
        public string? PurposeText { get; set; }
        public string? ReceiverName { get; set; }
        public string ReceiverIin { get; set; } = null!;
        public int PurposeType { get; set; }
        public DateTime? InsertDateTime { get; set; }
        public string? StatementNumber { get; set; }
        public string? SenderFio { get; set; }
        public int StatusId { get; set; }
        public string? CheckUserLogin { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? CheckComment { get; set; }
        public string? ColverId { get; set; }
        public string? Exception { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual ICollection<LongOrderFile> LongOrderFiles { get; set; }
    }
}
