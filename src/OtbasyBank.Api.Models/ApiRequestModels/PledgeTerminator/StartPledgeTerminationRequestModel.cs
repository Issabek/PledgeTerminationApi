using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Api.Models.ApiRequestModels.PledgeTerminator
{
    public class StartPledgeTerminationRequestModel
    {
        public string ClientIIN { get; set; }
        public string LoanId { get; set; }
        public string RKA
        {
            get; set;
        }
        internal string SysUserName { get; set; }

    }
}
