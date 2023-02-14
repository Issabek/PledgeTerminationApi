using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Document
    {
        public int Id { get; set; }
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string RefType { get; set; } = null!;
        public int RefId { get; set; }
        public string Ext { get; set; } = null!;
        public byte[] Binary { get; set; } = null!;
        public string ClientIin { get; set; } = null!;
        public Guid Guid { get; set; }
        public int Ordinal { get; set; }
    }
}
