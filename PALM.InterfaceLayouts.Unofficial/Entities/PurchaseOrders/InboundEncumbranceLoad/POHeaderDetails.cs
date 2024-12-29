using PALM.InterfaceLayouts.Unofficial.Attributes;
using PALM.InterfaceLayouts.Unofficial.Interfaces;
using PALM.InterfaceLayouts.Unofficial.Interfaces.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.InterfaceLayouts.Unofficial.Constants.PurchaseOrdersConstants;

namespace PALM.InterfaceLayouts.Unofficial.Entities.PurchaseOrders.InboundEncumbranceLoad
{
    public class POHeaderDetails : IRecordType, IPOHeaderDetails
    {
        public POHeaderDetails()
        {
            POLines = [];
        }

        #region Children
        public List<POLineDetails> POLines { get; set; }
        #endregion

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "H"; } }

        [Required]
        public POHeaderActions POHeaderAction { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? POHeaderActionFormatted { get { return Enum.GetName(typeof(POHeaderActions), POHeaderAction); } }

        [Required]
        [InterfaceFieldPosition(3)]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string? BusinessUnit { get; set; }

        [InterfaceFieldPosition(4)]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string? POID { get; set; }

        [InterfaceFieldPosition(5)]
        [AllowedValues(["Y", "N", null])]
        public string? HoldStatus { get; set; }

        public DateOnly? PODate { get; set; }
        [InterfaceFieldPosition(6)]
        internal string? PODateFormatted { get { return PODate?.ToString("MM/dd/yyyy"); } }

        [InterfaceFieldPosition(7)]
        [StringLength(maximumLength: 30)]
        public string? POReference { get; set; }

        [InterfaceFieldPosition(8)]
        [AllowedValues(["Y", "N", null])]
        public string? ConfidentialPO { get; set; }

        [InterfaceFieldPosition(9)]
        public static string SupplierSetID { get { return "STATE"; } }

        [InterfaceFieldPosition(10)]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string? SupplierID { get; set; }

        [InterfaceFieldPosition(11)]
        [StringLength(maximumLength: 10)]
        public string? SupplierLocation { get; set; }

        [InterfaceFieldPosition(12)]
        [Range(0, 99999)]
        public int? AddressSequenceNumber { get; set; }

        [Required]
        [InterfaceFieldPosition(13)]
        [StringLength(maximumLength: 3)]
        public string? POOrigin { get; set; }

        [InterfaceFieldPosition(14)]
        [AllowedValues(["Y", "N", null])]
        public string? ApprovalRequired { get; set; }

        [InterfaceFieldPosition(15)]
        [StringLength(maximumLength: 30)]
        public string? SourceSystemUserID { get; set; }

        [InterfaceFieldPosition(16)]
        [StringLength(maximumLength: 30)]
        public string? Filler1 { get; set; }

        [InterfaceFieldPosition(17)]
        [StringLength(maximumLength: 30)]
        public string? Filler2 { get; set; }

        [InterfaceFieldPosition(18)]
        [StringLength(maximumLength: 30)]
        public string? Filler3 { get; set; }

        [InterfaceFieldPosition(19)]
        [StringLength(maximumLength: 30)]
        public string? Filler4 { get; set; }

        [InterfaceFieldPosition(20)]
        [StringLength(maximumLength: 30)]
        public string? Filler5 { get; set; }
    }
}
