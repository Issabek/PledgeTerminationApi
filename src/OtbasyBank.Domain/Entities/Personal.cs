using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class Personal
    {
        public int UserId { get; set; }
        public string? Sname { get; set; }
        public string? Name { get; set; }
        public string? Fname { get; set; }
        public string? Position { get; set; }
    }
}
