using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RequestsHistory
    {
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
    }
}
