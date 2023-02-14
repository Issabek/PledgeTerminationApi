using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class OperBlock
    {
        public int OperBlockId { get; set; }
        public string OperName { get; set; } = null!;
        public string OperCode { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MessageRu { get; set; } = null!;
        public string MessageKk { get; set; } = null!;
        public bool? IsShowMessage { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string CreateAuthor { get; set; } = null!;
        public string? ChangeAuthor { get; set; }
    }
}
