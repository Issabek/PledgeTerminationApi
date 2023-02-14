using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserNotifyRepaymentSchedule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string LoanId { get; set; } = null!;
        public string ViewModelName { get; set; } = null!;
        public string? Parameters { get; set; }
        public DateTime? CreateDate { get; set; }
        public string NotifyMessageKaz { get; set; } = null!;
        public string NotifyMessageRu { get; set; } = null!;
        public string? CoborrowerClientCode { get; set; }
        public string? Stage { get; set; }
        public int? Ord { get; set; }
        public int? ClientId { get; set; }
    }
}
