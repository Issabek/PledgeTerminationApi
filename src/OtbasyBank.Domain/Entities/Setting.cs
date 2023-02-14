using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Setting
    {
        public string Code { get; set; } = null!;
        public string? SettingValue { get; set; }
    }
}
