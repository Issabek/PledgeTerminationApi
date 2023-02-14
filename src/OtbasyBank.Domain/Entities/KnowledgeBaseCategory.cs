using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class KnowledgeBaseCategory
    {
        public int KnowledgeBaseCategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? KnowledgeBaseParentCategoryId { get; set; }
    }
}
