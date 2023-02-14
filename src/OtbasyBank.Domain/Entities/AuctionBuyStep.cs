using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionBuyStep
    {
        public AuctionBuyStep()
        {
            AuctionProcesses = new HashSet<AuctionProcess>();
        }

        public int Id { get; set; }
        public Guid PublicKey { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? AgreementHtml { get; set; }
        public string? Otp { get; set; }
        public DateTime CreateDate { get; set; }
        public string? SelectDeposits { get; set; }
        public long UsersId { get; set; }
        public long? UsersUserId { get; set; }
        public DateTime? AgreementSignDate { get; set; }

        public virtual User? UsersUser { get; set; }
        public virtual ICollection<AuctionProcess> AuctionProcesses { get; set; }
    }
}
