using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Help
    {
        public string Id { get; set; } = null!;
        public string TitleKk { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string BodyKk { get; set; } = null!;
        public string BodyRu { get; set; } = null!;
        public string StatusId { get; set; } = null!;
        public string TopicId { get; set; } = null!;
        public int Priority { get; set; }

        public virtual HelpStatus Status { get; set; } = null!;
        public virtual HelpTopic Topic { get; set; } = null!;
    }
}
