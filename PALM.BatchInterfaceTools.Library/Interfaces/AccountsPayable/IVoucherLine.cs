using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable
{
    public interface IVoucherLine
    {
        public int VoucherLineNumber { get; set; }

        public string? LineDescription { get; set; }

        public decimal? Quantity { get; set; }

        public string? UnitofMeasure { get; set; }

        public decimal? Price { get; set; }

        public decimal? MerchandiseAmount { get; set; }

        public string? RelatedVoucher { get; set; }

        public DistributionMethodValues DistributionMethod { get; set; }

        public string? ShipToLocation { get; set; }

        public string? Merchant { get; set; }

        public string? Traveler { get; set; }

        public string? POBusinessUnit { get; set; }

        public string? POID { get; set; }

        public int? POLineNumber { get; set; }

        public string? ReceiptBusinessUnit { get; set; }

        public string? ReceiptID { get; set; }

        public int? ReceiptLineNumber { get; set; }

        public string? DocumentNumber { get; set; }

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
