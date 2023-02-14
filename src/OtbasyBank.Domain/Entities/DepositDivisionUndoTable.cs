using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositDivisionUndoTable
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public string? TerminateDepositId { get; set; }
        public string? MainDepositId { get; set; }
        public int RequestId { get; set; }
    }
}
