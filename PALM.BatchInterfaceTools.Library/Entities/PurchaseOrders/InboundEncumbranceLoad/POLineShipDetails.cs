using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Entities.PurchaseOrders.InboundEncumbranceLoad
{
    public class POLineShipDetails : IRecordType, IPOLineShipDetails
    {
        public POLineShipDetails()
        {
        }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "S"; } }

        public decimal? POTotalLineAmount { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? POTotalLineAmountFormatted { get { return POTotalLineAmount?.ToString("0.00"); } }

        public decimal? POQuantity { get; set; }
        [InterfaceFieldPosition(3)]
        internal string? POQuantityFormatted { get { return POQuantity?.ToString("#.###"); } }

        [InterfaceFieldPosition(4)]
        [StringLength(maximumLength: 30)]
        public string? Filler1 { get; set; }

        [InterfaceFieldPosition(5)]
        [StringLength(maximumLength: 30)]
        public string? Filler2 { get; set; }

        [InterfaceFieldPosition(6)]
        [StringLength(maximumLength: 30)]
        public string? Filler3 { get; set; }

        [InterfaceFieldPosition(7)]
        [StringLength(maximumLength: 30)]
        public string? Filler4 { get; set; }

        [InterfaceFieldPosition(8)]
        [StringLength(maximumLength: 30)]
        public string? Filler5 { get; set; }

        [InterfaceFieldPosition(9)]
        [StringLength(maximumLength: 30)]
        public string? Filler6 { get; set; }

        [InterfaceFieldPosition(10)]
        [StringLength(maximumLength: 30)]
        public string? Filler7 { get; set; }

        [InterfaceFieldPosition(11)]
        [StringLength(maximumLength: 30)]
        public string? Filler8 { get; set; }

        [InterfaceFieldPosition(12)]
        [StringLength(maximumLength: 30)]
        public string? Filler9 { get; set; }

        [InterfaceFieldPosition(13)]
        [StringLength(maximumLength: 30)]
        public string? Filler10 { get; set; }
    }
}
