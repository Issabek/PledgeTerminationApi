using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ClientVerificationPhoto
    {
        public byte[] ImageSrc { get; set; } = null!;
        public string Action { get; set; } = null!;
        public int ClientVerificationLogId { get; set; }
        public DateTime DateInserted { get; set; }

        public virtual ClientVerificationLog ClientVerificationLog { get; set; } = null!;
    }
}
