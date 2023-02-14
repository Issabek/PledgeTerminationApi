using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            AuctionBuySteps = new HashSet<AuctionBuyStep>();
            AuctionCancelLogs = new HashSet<AuctionCancelLog>();
            AuctionLogs = new HashSet<AuctionLog>();
            AuctionMoneyTransferLogBuyerUserUsers = new HashSet<AuctionMoneyTransferLog>();
            AuctionMoneyTransferLogSellerUserUsers = new HashSet<AuctionMoneyTransferLog>();
            AuctionProcesses = new HashSet<AuctionProcess>();
            AuctionSellSteps = new HashSet<AuctionSellStep>();
            AuctionSellersInProcesses = new HashSet<AuctionSellersInProcess>();
            AuctionUniversalProcessLoggers = new HashSet<AuctionUniversalProcessLogger>();
            Clients = new HashSet<Client>();
            Devices = new HashSet<Device>();
            UserAccesses = new HashSet<UserAccess>();
        }

        public long UserId { get; set; }
        public string UserLogin { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public DateTime? UserLastLoginDate { get; set; }
        public DateTime? UserLastPassChangeDate { get; set; }
        public DateTime? UserLastLockOutDate { get; set; }
        public int UserFailedPasswordAttemptCount { get; set; }
        public int UserType { get; set; }
        public string? UserEmail { get; set; }
        public int Status { get; set; }
        public DateTime UserCreateDate { get; set; }
        public DateTime UserFailedPasswordAttemptWindowStart { get; set; }
        public string? UserLanguage { get; set; }
        public DateTime? LastOdsupdateDate { get; set; }
        public DateTime? SynchColvirDate { get; set; }
        public DateTime? UserLastLoginChangeDate { get; set; }

        public virtual ICollection<AuctionBuyStep> AuctionBuySteps { get; set; }
        public virtual ICollection<AuctionCancelLog> AuctionCancelLogs { get; set; }
        public virtual ICollection<AuctionLog> AuctionLogs { get; set; }
        public virtual ICollection<AuctionMoneyTransferLog> AuctionMoneyTransferLogBuyerUserUsers { get; set; }
        public virtual ICollection<AuctionMoneyTransferLog> AuctionMoneyTransferLogSellerUserUsers { get; set; }
        public virtual ICollection<AuctionProcess> AuctionProcesses { get; set; }
        public virtual ICollection<AuctionSellStep> AuctionSellSteps { get; set; }
        public virtual ICollection<AuctionSellersInProcess> AuctionSellersInProcesses { get; set; }
        public virtual ICollection<AuctionUniversalProcessLogger> AuctionUniversalProcessLoggers { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<UserAccess> UserAccesses { get; set; }
    }
}
