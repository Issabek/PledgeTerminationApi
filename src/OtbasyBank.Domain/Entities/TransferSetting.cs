using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class TransferSetting
    {
        public int Id { get; set; }
        public string TransferTypeId { get; set; } = null!;
        public DateTime OperationTimeStart { get; set; }
        public DateTime OperationTimeFinish { get; set; }
        public string TariffColvirCode { get; set; } = null!;
        public decimal FeeRate { get; set; }
        public decimal FeeMinimum { get; set; }
        public decimal FeeMaximum { get; set; }
    }
}
