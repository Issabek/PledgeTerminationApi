using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RunaObj
    {
        public long Id { get; set; }
        public int? TypeObject { get; set; }
        public bool? Active { get; set; }
    }
}
