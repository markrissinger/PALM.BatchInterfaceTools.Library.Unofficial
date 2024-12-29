using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.InterfaceLayouts.Unofficial.Constants.PurchaseOrdersConstants;

namespace PALM.InterfaceLayouts.Unofficial.Interfaces.PurchaseOrders
{
    public interface IPODistributionDetails
    {
        public PODistributionActions PODistributionAction { get; set; }

        public int DistributionLineNumber { get; set; }

        public decimal? DistributionPOQuantity { get; set; }

        public decimal? DistributionPercentage { get; set; }

        public decimal? DistributionLineMerchandiseAmount { get; set; }

        public string? Organization { get; set; }

        public string? Account { get; set; }

        public string? Fund { get; set; }

        public string? BudgetEntity { get; set; }

        public string? Category { get; set; }

        public string? StateProgram { get; set; }

        public string? Grant { get; set; }

        public string? Contract { get; set; }

        public string? OA1 { get; set; }

        public string? OA2 { get; set; }

        public string? PCBusinessUnit { get; set; }

        public string? Project { get; set; }

        public string? Activity { get; set; }

        public string? PCSourceType { get; set; }

        public string? PCCategory { get; set; }

        public string? PCSubcategory { get; set; }

        public DateOnly? BudgetDate { get; set; }

        public string? AssetProfileID { get; set; }

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
