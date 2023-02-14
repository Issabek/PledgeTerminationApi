using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class ViewSmsSendOtpLog
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string RequestData { get; set; } = null!;
        public string ResponseData { get; set; } = null!;
        public int UserId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Iin { get; set; }
        public string? OperationCode { get; set; }
        public string? ClientCode { get; set; }
    }
}
