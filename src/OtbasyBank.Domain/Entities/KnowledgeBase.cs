using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class KnowledgeBase
    {
        public int KnowledgeBaseId { get; set; }
        public string? Topic { get; set; }
        public string? CreateUser { get; set; }
        public string? Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? KnowledgeBaseCategoryId { get; set; }
        public int? KnowledgeBaseParentCategoryId { get; set; }
    }
}
