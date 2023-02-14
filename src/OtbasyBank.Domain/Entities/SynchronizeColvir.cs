using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SynchronizeColvir
    {
        public long SynchronizeColvirId { get; set; }
        public long? UserId { get; set; }
        public string? ClientCode { get; set; }
        public string? ColumnName { get; set; }
        public string? TableName { get; set; }
        public string? OldData { get; set; }
        public string? NewData { get; set; }
        public string? Reason { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
