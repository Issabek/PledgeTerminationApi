using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Domain.Common
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TestPassword { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
