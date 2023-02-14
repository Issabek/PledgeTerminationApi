using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Kbe
    {
        public string Id { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public bool IsPrivate { get; set; }
    }
}
