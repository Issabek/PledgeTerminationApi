using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositCessionFree
    {
        public int Id { get; set; }
        public string? DepositId { get; set; }
        public string? ClientFromIin { get; set; }
        public string? ClientFromFio { get; set; }
        public string? ClientFromCode { get; set; }
        public string? ClientFromUserId { get; set; }
        public string? ClientToIin { get; set; }
        public string? ClientToFio { get; set; }
        public string? ClientToCode { get; set; }
        public string? ClientToUserId { get; set; }
        public DateTime? StartProcessTime { get; set; }
        public DateTime? EndProcessTime { get; set; }
        public int? StatusCode { get; set; }
        public int? TotalSteps { get; set; }
        public string? SuccessCode { get; set; }
        public string? ColvirId { get; set; }
        public string? RelationDegree { get; set; }
        public string? RequestLinkIdFrom { get; set; }
        public string? RequestLinkIdTo { get; set; }
    }
}
