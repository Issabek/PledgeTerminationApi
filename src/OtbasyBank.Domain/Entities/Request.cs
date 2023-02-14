using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Request
    {
        public Request()
        {
            Rates = new HashSet<Rate>();
            Transfers = new HashSet<Transfer>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public string? RegNum { get; set; }
        public string RequestData { get; set; } = null!;
        public string? ResponseData { get; set; }
        public int StatusId { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string? LinkId { get; set; }
        public string Name { get; set; } = null!;
        public int IsLastMsgRead { get; set; }
        public int? ParentRequest { get; set; }

        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
