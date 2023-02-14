using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class EgovRequest
    {
        public Guid Id { get; set; }
        public string RequestData { get; set; } = null!;
        public string? ResponseData { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid LinkId { get; set; }
        public int UserId { get; set; }
        public Guid? ParentId { get; set; }
        public string MethodName { get; set; } = null!;
        public int Status { get; set; }
    }
}
