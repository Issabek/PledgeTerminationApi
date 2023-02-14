using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RunaOpv
    {
        public long Id { get; set; }
        public long? ObjectId { get; set; }
        public int? PropertyId { get; set; }
        public object? Val { get; set; }
    }
}
