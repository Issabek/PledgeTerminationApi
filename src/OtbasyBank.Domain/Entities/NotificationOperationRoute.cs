using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class NotificationOperationRoute
    {
        public int OperationType { get; set; }
        public string Platform { get; set; } = null!;
        public string Route { get; set; } = null!;
        public string ButtonNameRu { get; set; } = null!;
        public string ButtonNameKk { get; set; } = null!;
    }
}
