using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Constants
{
    public static class AccountsPayableConstants
    {
        public const string InterfaceID = "POI002";
        public enum VoucherStyleValues { REG, SGLP, ADJ };
        public enum MatchActionValues { Y, N };
        public enum ConfidentialTransactionFlagValues { Y, N };
        public enum AuditValues { Y, N };
        public enum EmergencyVoucherValues { Y, N };
        public enum FinalPaymentValues { Y, N };
        public enum DistributionMethodValues { A, Q };
        public enum PaymentMethodValues { ACH, WIR, CHK, MAN };
        public enum PaymentActionValues { S, R };
        public enum AssetFlagValues { Y, N };
        public enum PaymentHoldFlagValues { Y, N };
        public enum SeparatePaymentFlagValues { Y, N };
    }
}
