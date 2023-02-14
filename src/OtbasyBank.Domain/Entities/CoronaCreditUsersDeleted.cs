using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class CoronaCreditUsersDeleted
    {
        public int Id { get; set; }
        public string Iin { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ClientCode { get; set; } = null!;
        public string ClientId { get; set; } = null!;
        public DateTime Date { get; set; }
        public string LoanId { get; set; } = null!;
        public string ColverReferenceId { get; set; } = null!;
        public bool? NeedTransferToHouseLoan { get; set; }
        public bool? NeedDelayLoan { get; set; }
        public DateTime? HouseLoanDate { get; set; }
    }
}
