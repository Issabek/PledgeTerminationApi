using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Api.Models.ApiRequestModels.PledgeTerminator
{
    public class ContinuePledgeTerminationRequestModel
    {
        public string Lang { get; set; }
        public string AppId { get; set; }
        public string Iin { get; set; }
    }
}
