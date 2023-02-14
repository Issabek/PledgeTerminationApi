using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Client
    {
        public Client()
        {
            ClientNotifications = new HashSet<ClientNotification>();
            DepositAuctionBidProcesses = new HashSet<DepositAuctionBidProcess>();
            DepositAuctionBids = new HashSet<DepositAuctionBid>();
            DepositAuctionLotHistories = new HashSet<DepositAuctionLotHistory>();
            DepositAuctionLotProcesses = new HashSet<DepositAuctionLotProcess>();
            DepositAuctionLots = new HashSet<DepositAuctionLot>();
            StandingOrders = new HashSet<StandingOrder>();
        }

        public int Id { get; set; }
        public string ClientCode { get; set; } = null!;
        public string ClientId { get; set; } = null!;
        public string ClientIin { get; set; } = null!;
        public long UserId { get; set; }
        public string? ClientFilialCode { get; set; }
        public string? Name { get; set; }
        public string? Sname { get; set; }
        public string? Fname { get; set; }
        public DateTime? SynchColvirDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<ClientNotification> ClientNotifications { get; set; }
        public virtual ICollection<DepositAuctionBidProcess> DepositAuctionBidProcesses { get; set; }
        public virtual ICollection<DepositAuctionBid> DepositAuctionBids { get; set; }
        public virtual ICollection<DepositAuctionLotHistory> DepositAuctionLotHistories { get; set; }
        public virtual ICollection<DepositAuctionLotProcess> DepositAuctionLotProcesses { get; set; }
        public virtual ICollection<DepositAuctionLot> DepositAuctionLots { get; set; }
        public virtual ICollection<StandingOrder> StandingOrders { get; set; }
    }
}
