using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class KnowledgeBaseTagConnect
    {
        public int KnowledgeBaseTagConnectId { get; set; }
        public int? KnowledgeBaseId { get; set; }
        public int? KnowledgeBaseTagId { get; set; }
    }
}
