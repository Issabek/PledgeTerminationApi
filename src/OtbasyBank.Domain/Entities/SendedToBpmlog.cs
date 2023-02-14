using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class SendedToBpmlog
    {
        public int? AuctionDepositId { get; set; }
        public int? UploadToBuyerFileId { get; set; }
        public int? UploadToSellerFileId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
