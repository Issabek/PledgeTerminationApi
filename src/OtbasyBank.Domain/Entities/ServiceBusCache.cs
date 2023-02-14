using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ServiceBusCache
    {
        public long? UserId { get; set; }
        public string? UserLogin { get; set; }
        public string? AltCode { get; set; }
        public string XmlData { get; set; } = null!;
        public int ModuleId { get; set; }
        public int ActionId { get; set; }
        public DateTime Created { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientId { get; set; }
        public string? XmlInputData { get; set; }
        public long CacheId { get; set; }
    }
}
