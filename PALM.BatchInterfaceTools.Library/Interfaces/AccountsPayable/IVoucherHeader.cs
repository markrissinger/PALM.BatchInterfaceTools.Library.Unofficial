using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable
{
    public interface IVoucherHeader
    {
        public string? APBusinessUnit { get; set; }

        public VoucherStyleValues VoucherStyle { get; set; }

        public string? VoucherOrigin { get; set; }

        public string? SupplierID { get; set; }

        public string? SupplierLocation { get; set; }

        public int? SupplierAddressSequenceNumber { get; set; }

        public int? RemitAddressSequenceNumber { get; set; }

        public string? InvoiceID { get; set; }

        public DateOnly? InvoiceDate { get; set; }

        public DateOnly? InvoiceReceiptDate { get; set; }

        public DateOnly? GoodsServicesReceivedDate { get; set; }

        public DateOnly? GoodsServicesApprovedDate { get; set; }

        public MatchActionValues MatchAction { get; set; }

        public DateOnly? AccountingDate { get; set; }

        public decimal? GrossAmount { get; set; }

        public string? PaymentTerms { get; set; }

        public ConfidentialTransactionFlagValues ConfidentialTransactionFlag { get; set; }

        public DateOnly? ServiceDateFrom { get; set; }

        public DateOnly? ServiceDateTo { get; set; }

        public string? SourceSystemUserId { get; set; }

        public AuditValues? Audit { get; set; }

        public EmergencyVoucherValues? EmergencyVoucher { get; set; }

        public FinalPaymentValues? FinalPayment { get; set; }

        // Intentionally skipping the filler fields to avoid unwanted side-effects in PALM
        //public string? Filler1 { get; set; }
        //public string? Filler2 { get; set; }
        //public string? Filler3 { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
    }
}
