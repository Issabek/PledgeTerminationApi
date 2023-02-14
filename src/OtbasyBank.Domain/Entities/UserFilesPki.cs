using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserFilesPki
    {
        public Guid UserFileGuid { get; set; }
        public long UserId { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientId { get; set; }
        public string ClientIin { get; set; } = null!;
        public int FileTypeId { get; set; }
        public string? FileName { get; set; }
        public int SourceSystem { get; set; }
        public DateTime Uploaded { get; set; }
        public string SourceReqCode { get; set; } = null!;
        public byte[] FileData { get; set; } = null!;
        public DateTime? Deleted { get; set; }
        public bool? IsDelete { get; set; }
        public string? SourceReqNum { get; set; }
        public long UserFileId { get; set; }
        public long BankFileId { get; set; }
    }
}
