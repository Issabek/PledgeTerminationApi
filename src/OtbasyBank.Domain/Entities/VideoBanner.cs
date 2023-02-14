using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class VideoBanner
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Link { get; set; } = null!;
        public string ImageLoc { get; set; } = null!;
        public int Category { get; set; }
        public string CategoryDescription { get; set; } = null!;
        public int Priority { get; set; }
        public string Lang { get; set; } = null!;
        public bool ShowToAuthorized { get; set; }
    }
}
