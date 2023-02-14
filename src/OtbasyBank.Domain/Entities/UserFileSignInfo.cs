using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserFileSignInfo
    {
        public Guid UserFileGuid { get; set; }
        public string? ClientSignResult { get; set; }
        public DateTime? ClientSigned { get; set; }
        public bool? IsClientSignWithFile { get; set; }
        public string? BankSignResult { get; set; }
        public DateTime? BankSigned { get; set; }
        public bool? IsBankSignWithFile { get; set; }
        public string? ClientKeyInfo { get; set; }
        public string? BankKeyInfo { get; set; }
    }
}
