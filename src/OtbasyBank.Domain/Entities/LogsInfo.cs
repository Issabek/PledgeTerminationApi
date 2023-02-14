using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogsInfo
    {
        public int Id { get; set; }
        public long? UserId { get; set; }
        public string? Query { get; set; }
        public DateTime? SendingDate { get; set; }
        public string? Comment { get; set; }
        public int? Type { get; set; }
    }
}
