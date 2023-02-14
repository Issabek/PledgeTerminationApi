using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionSellStep
    {
        public int Id { get; set; }
        public Guid PublicKey { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Duration { get; set; }
        public string? DepositId { get; set; }
        public DateTime CreateDate { get; set; }
        public string? StatementHtml { get; set; }
        public string? Otp { get; set; }
        public string? DisplaydepositId { get; set; }
        public long UsersId { get; set; }
        public long? UsersUserId { get; set; }
        public DateTime? StatementSignDate { get; set; }

        public virtual User? UsersUser { get; set; }
    }
}
