using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class HistoryOld
    {
        public int HistoryId { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string? UserIp { get; set; }
        public int? ActionType { get; set; }
        public string? ActionName { get; set; }
        public string? ObjectType { get; set; }
        public int? ObjectId { get; set; }
        public string? ObjectInfo { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public int? CheaterUserId { get; set; }
        public string? IpRegionName { get; set; }
        public string? IpLat { get; set; }
        public string? IpLon { get; set; }
        public string? Headurl { get; set; }
    }
}
