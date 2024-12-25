using PALM.InterfaceLayouts.Unofficial.Attributes;
using PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad.Constants;

namespace PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrders.InboundEncumbranceLoad
{
    public class POLineDetails : IRecordType
    {
        public POLineDetails()
        {
            POLineShipDetails = new POLineShipDetails();
            PODistributionDetails = [];
        }

        public POLineShipDetails POLineShipDetails { get; set; }

        //private List<PODistributionDetails> _poDistributionDetails;
        public List<PODistributionDetails> PODistributionDetails { get; set; }
        //public PODistributionDetails CreatePODistributionLine()
        //{
        //    PODistributionDetails poDistributionDetails = new PODistributionDetails();
        //    _poDistributionDetails.Add(poDistributionDetails);
        //    return poDistributionDetails;
        //}

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "L"; } }

        [Required]
        public POLineActions POLineAction { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? POLineActionsFormatted { get { return Enum.GetName(typeof(POLineActions), POLineAction); } }

        [Required]
        [InterfaceFieldPosition(3)]
        public int LineNumber { get; set; }

        [InterfaceFieldPosition(4)]
        [StringLength(maximumLength: 18, MinimumLength = 18)]
        public string? CategoryCode { get; set; }

        [InterfaceFieldPosition(5)]
        public string? UnitOfMeasure { get; set; }

        [InterfaceFieldPosition(6)]
        [AllowedValues(["Y", "N", null])]
        public string? AmountOnlyFlag {  get; set; }

        [InterfaceFieldPosition(7)]
        [AllowedValues(["G", "S", null])]
        public string? PhysicalNature { get; set; }

        [InterfaceFieldPosition(8)]
        [StringLength(maximumLength: 254, MinimumLength = 1)]
        public string? ItemDescription { get; set; }

        [InterfaceFieldPosition(9)]
        [StringLength(maximumLength: 30)]
        public string? Filler1 { get; set; }

        [InterfaceFieldPosition(10)]
        [StringLength(maximumLength: 30)]
        public string? Filler2 { get; set; }

        [InterfaceFieldPosition(11)]
        [StringLength(maximumLength: 30)]
        public string? Filler3 { get; set; }

        [InterfaceFieldPosition(12)]
        [StringLength(maximumLength: 30)]
        public string? Filler4 { get; set; }

        [InterfaceFieldPosition(13)]
        [StringLength(maximumLength: 30)]
        public string? Filler5 { get; set; }

        [InterfaceFieldPosition(14)]
        [StringLength(maximumLength: 30)]
        public string? Filler6 { get; set; }

        [InterfaceFieldPosition(15)]
        [StringLength(maximumLength: 30)]
        public string? Filler7 { get; set; }

        [InterfaceFieldPosition(16)]
        [StringLength(maximumLength: 30)]
        public string? Filler8 { get; set; }

        [InterfaceFieldPosition(17)]
        [StringLength(maximumLength: 30)]
        public string? Filler9 { get; set; }

        [InterfaceFieldPosition(18)]
        [StringLength(maximumLength: 30)]
        public string? Filler10 { get; set; }
    }
}
