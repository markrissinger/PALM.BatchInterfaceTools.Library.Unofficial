using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad
{
    public class VoucherPayment : IRecordType, IVoucherPayment
    {
        public VoucherPayment() { }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "P"; } }

        public PaymentMethodValues? PaymentMethod { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? PaymentMethodFormatted { get { return PaymentMethod.HasValue ? Enum.GetName(typeof(PaymentMethodValues), PaymentMethod) : string.Empty; } }

        [StringLength(maximumLength: 6)]
        [InterfaceFieldPosition(3)]
        public string? PaymentMessageCode { get; set; }

        [Required]
        [StringLength(maximumLength: 2)]
        [InterfaceFieldPosition(4)]
        public string? PaymentHandlingCode { get; set; }

        public PaymentHoldFlagValues? PaymentHoldFlag { get; set; }
        [InterfaceFieldPosition(5)]
        internal string? PaymentHoldFlagFormatted { get { return PaymentHoldFlag.HasValue ? Enum.GetName(typeof(PaymentHoldFlagValues), PaymentHoldFlag) : string.Empty; } }

        [StringLength(maximumLength: 3)]
        [InterfaceFieldPosition(6)]
        public string? PaymentHoldReason { get; set; }

        public DateOnly? ScheduledPaymentDate { get; set; }
        [InterfaceFieldPosition(7)]
        internal string? ScheduledPaymentDateFormatted { get { return ScheduledPaymentDate?.ToString("MM/dd/yyyy"); } }

        public SeparatePaymentFlagValues? SeparatePaymentFlag { get; set; }
        [InterfaceFieldPosition(8)]
        internal string? SeparatePaymentFlagFormatted { get { return SeparatePaymentFlag.HasValue ? Enum.GetName(typeof(SeparatePaymentFlagValues), SeparatePaymentFlag) : string.Empty; } }

        [StringLength(maximumLength: 2)]
        [InterfaceFieldPosition(9)]
        public string? PayGroupCode { get; set; }

        [Required]
        public PaymentActionValues PaymentAction { get; set; }
        [InterfaceFieldPosition(10)]
        internal string? PaymentActionFormatted { get { return Enum.GetName(typeof(PaymentActionValues), PaymentAction); } }

        [StringLength(maximumLength: 20)]
        [InterfaceFieldPosition(11)]
        public string? PaymentReferenceNumber { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(12)]
        public string? Filler1 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(13)]
        public string? Filler2 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(14)]
        public string? Filler3 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(15)]
        public string? Filler4 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(16)]
        public string? Filler5 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(17)]
        public string? Filler6 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(18)]
        public string? Filler7 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(19)]
        public string? Filler8 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(20)]
        public string? Filler9 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(21)]
        public string? Filler10 { get; set; }
    }
}
