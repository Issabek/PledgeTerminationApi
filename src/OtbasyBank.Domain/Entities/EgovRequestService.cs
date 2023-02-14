using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class EgovRequestService
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public int ServiceFileId { get; set; }
        public string ServiceCode { get; set; } = null!;
        public string? ServiceName { get; set; }
        public string ServiceUrl { get; set; } = null!;
        public string? ErrMess { get; set; }
        public string? ServiceData { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
