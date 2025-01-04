using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable
{
    public interface IVoucherPayment
    {
        public PaymentMethodValues? PaymentMethod { get; set; }

        public string? PaymentMessageCode { get; set; }

        public string? PaymentHandlingCode { get; set; }

        public PaymentHoldFlagValues? PaymentHoldFlag { get; set; }

        public string? PaymentHoldReason { get; set; }

        public DateOnly? ScheduledPaymentDate { get; set; }

        public SeparatePaymentFlagValues? SeparatePaymentFlag { get; set; }

        public string? PayGroupCode { get; set; }

        public PaymentActionValues PaymentAction { get; set; }

        public string? PaymentReferenceNumber { get; set; }

        // Intentionally skipping the filler fields to avoid unwanted side-effects in PALM
        //public string? Filler1 { get; set; }
        //public string? Filler2 { get; set; }
        //public string? Filler3 { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
        //public string? Filler6 { get; set; }
        //public string? Filler7 { get; set; }
        //public string? Filler8 { get; set; }
        //public string? Filler9 { get; set; }
        //public string? Filler10 { get; set; }
    }
}
