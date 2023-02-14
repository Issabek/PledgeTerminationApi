using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class KnowledgeBaseFile
    {
        public int KnowledgeBaseFileId { get; set; }
        public int? KnowledgeBaseId { get; set; }
        public string? FileName { get; set; }
        public byte[]? FileData { get; set; }
    }
}
