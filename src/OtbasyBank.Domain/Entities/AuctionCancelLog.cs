using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class AuctionCancelLog
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsSeller { get; set; }
        public int CancelStatusId { get; set; }
        public int? AuctionDepositsId { get; set; }
        public int? AuctionProcessId { get; set; }
        public string? CancelAgreement { get; set; }
        public string? CancelOtp { get; set; }
        public long? UserId { get; set; }
        public bool IsCancelled { get; set; }
        public bool UnblockDeposit { get; set; }
        public bool IsUnblocked { get; set; }
        public DateTime? UnblockDate { get; set; }
        public int UnblockTryCount { get; set; }
        public string? UnblockException { get; set; }
        public bool ReturnDeposit { get; set; }
        public bool IsReturned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int ReturnTryCount { get; set; }
        public string? ReturnException { get; set; }
        public bool SendSms { get; set; }
        public bool IsSmsSent { get; set; }
        public string? SmsText { get; set; }
        public DateTime? SmsDate { get; set; }
        public int SmsTryCount { get; set; }
        public string? SmsException { get; set; }
        public bool SendEmail { get; set; }
        public bool IsEmailSent { get; set; }
        public string? EmailText { get; set; }
        public DateTime? EmailDate { get; set; }
        public int EmailTryCount { get; set; }
        public string? EmailException { get; set; }

        public virtual AuctionDeposit? AuctionDeposits { get; set; }
        public virtual AuctionProcess? AuctionProcess { get; set; }
        public virtual AuctionDepositStatus CancelStatus { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
