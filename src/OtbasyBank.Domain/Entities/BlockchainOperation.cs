using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class BlockchainOperation
    {
        public int Id { get; set; }
        public string Stage { get; set; } = null!;
        public string LoanId { get; set; } = null!;
        public string PledgeId { get; set; } = null!;
        public string AppId { get; set; } = null!;
        public string Rka { get; set; } = null!;
        public string? Parameters { get; set; }
        public string? LetterInfo { get; set; }
        public DateTime? StatusNew { get; set; }
        public DateTime? StatusVerified { get; set; }
        public DateTime? StatusRejected { get; set; }
        public DateTime? StatusRecall { get; set; }
        public DateTime? StatusSuspendedNotPaid { get; set; }
        public DateTime? StatusPaid { get; set; }
        public DateTime? StatusCanceled { get; set; }
        public DateTime? StatusRegistered { get; set; }
    }
}
