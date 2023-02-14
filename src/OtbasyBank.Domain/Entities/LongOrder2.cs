using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LongOrder2
    {
        public LongOrder2()
        {
            LongOrderCheck2s = new HashSet<LongOrderCheck2>();
            LongOrderFiles2s = new HashSet<LongOrderFiles2>();
        }

        public int Id { get; set; }
        public string Token { get; set; } = null!;
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

        public virtual LongOrderType OrderType { get; set; } = null!;
        public virtual LongOrderPurpose PurposeTypeNavigation { get; set; } = null!;
        public virtual ICollection<LongOrderCheck2> LongOrderCheck2s { get; set; }
        public virtual ICollection<LongOrderFiles2> LongOrderFiles2s { get; set; }
    }
}
