using OtbasyBank.Shared.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Api.Models.ApiResponseModels.PledgeTerminator
{
    public class GetBlockchainInfoResponseModel
    {
        public string AppId { get; set; }
        public PaymentData paymentData { get; set; }
        public string status { get; set; }
        public Suspend suspend { get; set; }
        public Notification notification { get; set; }
    }
}
