using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.Interfaces.PurchaseOrders
{
    public interface IPOLineShipDetails
    {
        public decimal? POTotalLineAmount { get; set; }

        public decimal? POQuantity { get; set; }

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
