using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HistoryActionsByDate
    {
        public string? ActionName { get; set; }
        public int? Counttt { get; set; }
        public int? ActionType { get; set; }
        public DateTime? Datestr { get; set; }
    }
}
