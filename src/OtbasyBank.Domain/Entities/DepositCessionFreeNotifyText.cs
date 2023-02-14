using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositCessionFreeNotifyText
    {
        public int Id { get; set; }
        public string? MessageCode { get; set; }
        public string? MessageTextRu { get; set; }
        public string? MessageTextKaz { get; set; }
    }
}
