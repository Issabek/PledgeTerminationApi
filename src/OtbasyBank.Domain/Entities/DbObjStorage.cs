using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DbObjStorage
    {
        public string SourceId { get; set; } = null!;
        public long? UserId { get; set; }
        public string? DataAsJson { get; set; }
        public string? DataAsXml { get; set; }
    }
}
