using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class NewsStatus
    {
        public NewsStatus()
        {
            News = new HashSet<News>();
            RssNews = new HashSet<RssNews>();
        }

        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public bool DoDisplay { get; set; }

        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<RssNews> RssNews { get; set; }
    }
}
