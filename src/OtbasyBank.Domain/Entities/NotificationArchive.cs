using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class NotificationArchive
    {
        public long Id { get; set; }
        public string TypeId { get; set; } = null!;
        public string StatusId { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string BodyKk { get; set; } = null!;
        public string BodyRu { get; set; } = null!;
        public bool IsBlocker { get; set; }
        public int? ClientId { get; set; }
        public Guid? Guid { get; set; }
        public int? CategoryId { get; set; }
        public int? OperationType { get; set; }
        public string? MediaSourceType { get; set; }
        public string? MediaSourceRef { get; set; }

        public virtual NotificationStatus Status { get; set; } = null!;
        public virtual NotificationType Type { get; set; } = null!;
    }
}
