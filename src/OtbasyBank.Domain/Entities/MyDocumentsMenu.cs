using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MyDocumentsMenu
    {
        public long Id { get; set; }
        public string? ItemType { get; set; }
        public string? ItemName { get; set; }
        public string? ItemNameKaz { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long ParentId { get; set; }
        public string? Code { get; set; }
        public long? BackId { get; set; }
        public string? Title { get; set; }
        public string? TitleKaz { get; set; }
        public int? FileTypeId { get; set; }
        public int? CntNewFiles { get; set; }
    }
}
