using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Api.Models.ApiResponseModels.PledgeTerminator
{
    public class GetLetterEncumbrancesResponseModel
    {
        public string LnCode { get; set; }
        public string DateBegin { get; set; }
        public string CliLongName { get; set; }
        public string FltAddress { get; set; }
        public string DclCode { get; set; }
        public string EnsCode { get; set; }
        public string DocNumber { get; set; }
        public string DocDate { get; set; }
        public string PledgeDocNumber { get; set; }
        public string PledgeDocDate { get; set; }
        public List<string> AdditionalDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalDocDate { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocNumber { get; set; } = new List<string>();
        public List<string> AdditionalPledgeDocDate { get; set; } = new List<string>();
        public List<string> TaxCodes { get; set; } = new List<string>();
        public List<string> CliCodes { get; set; } = new List<string>();
        public List<string> CliNames { get; set; } = new List<string>();
    }
}
