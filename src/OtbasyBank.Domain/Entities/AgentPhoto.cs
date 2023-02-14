using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AgentPhoto
    {
        public string Iin { get; set; } = null!;
        public DateTime DateUpdated { get; set; }
        public bool IsIcon { get; set; }
        public byte[] Blob { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Contract { get; set; }
        public string? Poa { get; set; }
    }
}
