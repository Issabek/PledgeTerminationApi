using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class UserToDeactivate
    {
        public int Id { get; set; }
        public string RequestId { get; set; } = null!;
        public string UserDomainAccount { get; set; } = null!;
        public string InitialUser { get; set; } = null!;
        public DateTime DeactivateDate { get; set; }
        public int State { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
