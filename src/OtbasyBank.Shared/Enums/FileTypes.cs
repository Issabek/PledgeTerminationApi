using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtbasyBank.Shared.Enums
{

        public enum UserFileTypes
        {
             GSVP_CLIENT_APPLICANT_INFO = 1,
             PKB_CLIENT_AGREEMENT_GET = 2,
             PKB_CLIENT_AGREEMENT_GIVE = 3,

             GSVP_SPOUSE_APPLICANT_INFO = 4,
             PKB_SPOUSE_AGREEMENT_GET = 5,
             PKB_SPOUSE_AGREEMENT_GIVE = 6,

             LOAN_CLIENT_PREAGREEMENT_GET = 7,
             CLIENT_ANKETA_PODFT_GET = 9,

             DEPOSIT_CREATE_APPLICANT_GENERAL_CONDITIONS = 10,
             DEPOSIT_CREATE_CERTIFICATE = 11,

             DEPOSIT_EDIT_APPLICANT = 12,
             DEPOSIT_EDIT_DOP_AGREEMENT = 13,

             DEPOSIT_UNION_APPLICANT = 14,
             DEPOSIT_UNION_DOP_AGREEMENT = 15,
             DEPOSIT_UNION_APPLICANT_GOSPREM = 16,

             CREDIT_HOUSING_APPLICANT = 17,
             CREDIT_PAYMENT_SCHEDULE = 18,
             CREDIT_MEMO_BORROWER = 19,

             DEPOSIT_EDIT_CERTIFICATE = 20,
             DEPOSIT_UNION_CERTIFICATE = 21,

             DEPOSIT_TERMINATE_APPLICANT = 22,
             CLIENT_IDENTITY_DOCUMENT_PICTURE_FRONT_SIDE = 23,
             CLIENT_IDENTITY_DOCUMENT_PICTURE_BACK_SIDE = 24,
             CLIENT_SELF_PICTURE = 25,
             CLIENT_EDIT_APPLICATION = 26,

             DEPOSIT_DIVIDE_APPLICANT = 27,

             LOAN_FULL_REPAYMENT_APPLICANT = 28,

             LOAN_REPAYMENT = 29,
             REPAYMENT_SCHEDULE = 30,

             AGREEMENT_TO_PERSONAL_INFORMATION = 31,
             GCVP_APPLICATION = 32,
             AGREEMENT_TO_PKB = 33,


             DEPOSIT_REFILL_APPLICANT = 34,
             DEPOSIT_STOP_APPLICANT = 36,
             AGREEMENT_TO_GKB = 37,
             RELATIVE_CONFIRMATION = 38,
             DEPOSIT_CESSION_CLAIM = 39,

             PLEDGE_TERMINATE_NOTIFICATION = 42,
             PLEDGE_TERMINATE_REQUISITE = 40,
             NOTIFICATION_OF_THE_COMPLETED_STATE_REGISTRATION = 41,


        }

    
}
