using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public long UsersId { get; set; }
        public string? Text { get; set; }
        public int? ProcessId { get; set; }
        public string? AuctionType { get; set; }
        public int TimeSec { get; set; }
        public bool IsError { get; set; }
        public long? UsersUserId { get; set; }

        public virtual AuctionProcess? Process { get; set; }
        public virtual User? UsersUser { get; set; }
    }
}
