using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable
{
    public interface IVoucherDistribution
    {
        public int VoucherLineNumber { get; set; }

        public int VoucherDistributionLineNumber { get; set; }

        public decimal? DistributionLineMerchandiseAmount { get; set; }

        public decimal? DistributionLineQuantity { get; set; }

        public string? GLBusinessUnit { get; set; }

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

        public string? Subcategory { get; set; }

        public DateOnly? BudgetDate { get; set; }

        public int? POLineNumber { get; set; }

        public int? PODistributionLineNumber { get; set; }

        public int? ReceiptLineNumber { get; set; }

        public int? ReceiptDistributionLineNumber { get; set; }

        public string? AssetIDReference { get; set; }

        public AssetFlagValues? AssetFlag { get; set; }

        public string? AMBusinessUnit { get; set; }

        public string? AssetID { get; set; }

        public string? ProfileID { get; set; }

        // Intentionally skipping the filler fields to avoid unwanted side-effects in PALM
        //public string? Filler1 { get; set; }
        //public string? Filler2 { get; set; }
        //public string? Filler3 { get; set; }
        //public string? Filler4 { get; set; }
        //public string? Filler5 { get; set; }
    }
}
