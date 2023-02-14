using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class DepositCessionFreeSetting
    {
        public int Id { get; set; }
        public DateTime ServiceEnableDateStart { get; set; }
        public DateTime ServiceEnableDateEnd { get; set; }
        public DateTime OperationTimeFinish { get; set; }
    }
}
