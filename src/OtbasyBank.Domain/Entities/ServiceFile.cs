using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ServiceFile
    {
        public string? ColvirReferenceId { get; set; }
        public string? ClientCode { get; set; }
        public string? ServiceMethod { get; set; }
        public byte[]? FileContent { get; set; }
        public string? FileName { get; set; }
        public long? FileType { get; set; }
        public string? UserBranchName { get; set; }
        public string? UserDepName { get; set; }
        public int? IsCopied { get; set; }
        public string? FileId { get; set; }
        public DateTime? RunTime { get; set; }
        public int? ErrorCount { get; set; }
        public long BankFileId { get; set; }
        public int Id { get; set; }
    }
}
