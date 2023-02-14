using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class GetAveragePointsForProcessesAllTimeView
    {
        public string RequestType { get; set; } = null!;
        public double? AveragePoint { get; set; }
        public int? AmountPeople { get; set; }
    }
}
