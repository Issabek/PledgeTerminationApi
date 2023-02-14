using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class GetLog4NetLogAuthLogWithArhView
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Userlogin { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; } = null!;
        public string Level { get; set; } = null!;
        public string Logger { get; set; } = null!;
        public string? Controller { get; set; }
        public string? Method { get; set; }
        public string? Description { get; set; }
        public string Message { get; set; } = null!;
        public string Result { get; set; } = null!;
        public string? Exception { get; set; }
        public string? TypeSystem { get; set; }
    }
}
