using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RequestsStatusType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? NameKz { get; set; }
    }
}
