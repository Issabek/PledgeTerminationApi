using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class RunaObjProp
    {
        public int Id { get; set; }
        public int? ObjTypeId { get; set; }
        public int? ObjPropId { get; set; }
        public string? Comment { get; set; }
    }
}
