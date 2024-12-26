using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.InterfaceLayouts.Unofficial.Constants.PurchaseOrdersConstants;

namespace PALM.InterfaceLayouts.Unofficial.Interfaces.PurchaseOrders
{
    public interface IPOHeaderDetails
    {
        public POHeaderActions POHeaderAction { get; set; }

        public string? BusinessUnit { get; set; }

        public string? POID { get; set; }

        public string? HoldStatus { get; set; }

        public DateOnly? PODate { get; set; }

        public string? POReference { get; set; }

        public string? ConfidentialPO { get; set; }

        public static string? SupplierSetID { get; }

        public string? SupplierID { get; set; }

        public string? SupplierLocation { get; set; }

        public int? AddressSequenceNumber { get; set; }

        public string? POOrigin { get; set; }

        public string? ApprovalRequired { get; set; }

        public string? SourceSystemUserID { get; set; }

        // Intentionally skipping the filler fields to avoid unwanted side-effects in PALM
        //public string? Filler1 { get; set; }
        //public string? Filler2 { get; set; }
        //public string? Filler3 { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
    }
}
