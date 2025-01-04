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
    public class VoucherHeader : IRecordType, IVoucherHeader
    {
        public VoucherHeader()
        {
            VoucherLines = [];
            VoucherPayment = new VoucherPayment();
        }

        #region Children
        public List<VoucherLine> VoucherLines { get; set; }

        public VoucherSupplier? VoucherSupplier { get; set; }

        public VoucherPayment VoucherPayment { get; set; }
        #endregion

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "H"; } }

        [Required]
        [InterfaceFieldPosition(2)]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string? APBusinessUnit { get; set; }

        [Required]
        public VoucherStyleValues VoucherStyle { get; set; }
        [InterfaceFieldPosition(3)]
        internal string? VoucherStyleFormatted { get { return Enum.GetName(typeof(VoucherStyleValues), VoucherStyle); } }

        [Required]
        [InterfaceFieldPosition(4)]
        public string? VoucherOrigin { get; set; }

        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [InterfaceFieldPosition(5)]
        public string? SupplierID { get; set; }

        [StringLength(maximumLength: 10)]
        [InterfaceFieldPosition(6)]
        public string? SupplierLocation { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(7)]
        public int? SupplierAddressSequenceNumber { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(8)]
        public int? RemitAddressSequenceNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(9)]
        public string? InvoiceID { get; set; }

        [Required]
        public DateOnly? InvoiceDate { get; set; }
        [InterfaceFieldPosition(10)]
        internal string? InvoiceDateFormatted { get { return InvoiceDate?.ToString("MM/dd/yyyy"); } }

        [Required]
        public DateOnly? InvoiceReceiptDate { get; set; }
        [InterfaceFieldPosition(11)]
        internal string? InvoiceReceiptDateFormatted { get { return InvoiceReceiptDate?.ToString("MM/dd/yyyy"); } }

        [Required]
        public DateOnly? GoodsServicesReceivedDate { get; set; }
        [InterfaceFieldPosition(12)]
        internal string? GoodsServicesReceivedDateFormatted { get { return GoodsServicesReceivedDate?.ToString("MM/dd/yyyy"); } }

        [Required]
        public DateOnly? GoodsServicesApprovedDate { get; set; }
        [InterfaceFieldPosition(13)]
        internal string? GoodsServicesApprovedDateFormatted { get { return GoodsServicesApprovedDate?.ToString("MM/dd/yyyy"); } }

        [Required]
        public MatchActionValues MatchAction { get; set; }
        [InterfaceFieldPosition(14)]
        internal string? MatchActionFormatted { get { return Enum.GetName(typeof(MatchActionValues), MatchAction); } }

        [Required]
        public DateOnly? AccountingDate { get; set; }
        [InterfaceFieldPosition(15)]
        internal string? AccountingDateFormatted { get { return AccountingDate?.ToString("MM/dd/yyyy"); } }

        public decimal? GrossAmount { get; set; }
        [InterfaceFieldPosition(16)]
        internal string? GrossAmountFormatted { get { return GrossAmount?.ToString("0.00"); } }

        [Required]
        [StringLength(maximumLength: 5)]
        [InterfaceFieldPosition(17)]
        public string? PaymentTerms { get; set; }

        [Required]
        public ConfidentialTransactionFlagValues ConfidentialTransactionFlag { get; set; }
        [InterfaceFieldPosition(18)]
        internal string? ConfidentialTransactionFlagFormatted { get { return Enum.GetName(typeof(ConfidentialTransactionFlagValues), ConfidentialTransactionFlag); } }

        public DateOnly? ServiceDateFrom { get; set; }
        [InterfaceFieldPosition (19)]
        internal string? ServiceDateFromFormatted { get { return ServiceDateFrom?.ToString("MM/dd/yyyy"); } }

        public DateOnly? ServiceDateTo { get; set; }
        [InterfaceFieldPosition(20)]
        internal string? ServiceDateToFormatted { get { return ServiceDateTo?.ToString("MM/dd/yyyy"); } }

        [StringLength(maximumLength: 100)]
        [InterfaceFieldPosition(21)]
        public string? SourceSystemUserId { get; set; }

        public AuditValues? Audit { get; set; }
        [InterfaceFieldPosition(22)]
        internal string? AuditFormatted { get { return Audit.HasValue ? Enum.GetName(typeof(AuditValues), Audit) : string.Empty; } }

        public EmergencyVoucherValues? EmergencyVoucher { get; set; }
        [InterfaceFieldPosition(23)]
        internal string? EmergencyVoucherFormatted { get { return EmergencyVoucher.HasValue ? Enum.GetName(typeof(EmergencyVoucherValues), EmergencyVoucher) : string.Empty; } }

        public FinalPaymentValues? FinalPayment { get; set; }
        [InterfaceFieldPosition(24)]
        internal string? FinalPaymentFormatted { get { return FinalPayment.HasValue ? Enum.GetName(typeof(FinalPaymentValues), FinalPayment) : string.Empty; } }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(25)]
        public string? Filler1 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(26)]
        public string? Filler2 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(27)]
        public string? Filler3 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(28)]
        public string? Filler4 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(29)]
        public string? Filler5 { get; set; }
    }
}
