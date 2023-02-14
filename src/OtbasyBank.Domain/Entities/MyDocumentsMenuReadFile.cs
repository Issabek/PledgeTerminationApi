using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class MyDocumentsMenuReadFile
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? FileTableName { get; set; }
        public long? UserFileId { get; set; }
        public DateTime? ReadingDate { get; set; }
    }
}
