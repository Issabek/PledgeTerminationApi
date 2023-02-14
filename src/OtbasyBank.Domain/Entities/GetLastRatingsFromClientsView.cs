using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class GetLastRatingsFromClientsView
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public int Points { get; set; }
        public string? Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; } = null!;
        public string ClientIin { get; set; } = null!;
        public string Fio { get; set; } = null!;
    }
}
