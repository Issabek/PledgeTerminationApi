using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class LogSoapEnvelope
    {
        public long Id { get; set; }
        public string? Action { get; set; }
        public string? Endpoint { get; set; }
        public DateTime RequestDt { get; set; }
        public DateTime? ResponseDt { get; set; }
        public string RequestMessage { get; set; } = null!;
        public string? ResponseMessage { get; set; }
        public string SystemName { get; set; } = null!;
        public string? UserLogin { get; set; }
    }
}
