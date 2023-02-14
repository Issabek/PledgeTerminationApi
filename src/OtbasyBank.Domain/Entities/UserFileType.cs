using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserFileType
    {
        public int FileTypeId { get; set; }
        public string? FileTypeName { get; set; }
        public bool? NeedClientSign { get; set; }
        public bool? NeedBankSign { get; set; }
        public int? FileStorageTime { get; set; }
        public int Status { get; set; }
        public int? BankFileTypeId { get; set; }
    }
}
