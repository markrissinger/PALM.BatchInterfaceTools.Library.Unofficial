using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.PurchaseOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.PurchaseOrdersConstants;

namespace PALM.BatchInterfaceTools.Library.Entities.PurchaseOrders.InboundEncumbranceLoad
{
    public class PODistributionDetails : IRecordType, IPODistributionDetails
    {
        public PODistributionDetails()
        {
        }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "D"; } }

        [Required]
        public PODistributionActionValues PODistributionAction { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? PODistributionActionFormatted { get { return Enum.GetName(typeof(PODistributionActionValues), PODistributionAction); } }

        [Required]
        [InterfaceFieldPosition(3)]
        [Range(0, 99999)]
        public int DistributionLineNumber { get; set; }

        public decimal? DistributionPOQuantity { get; set; }
        [InterfaceFieldPosition(4)]
        public string? DistributionPOQuantityFormatted { get { return DistributionPOQuantity?.ToString("#.###"); } }

        public decimal? DistributionPercentage { get; set; }
        [InterfaceFieldPosition(5)]
        internal string? DistributionPercentageFormatted { get { return DistributionPercentage?.ToString("#.##"); } }

        public decimal? DistributionLineMerchandiseAmount { get; set; }
        [InterfaceFieldPosition(6)]
        internal string? DistributionLineMerchandiseAmountFormatted { get { return DistributionLineMerchandiseAmount?.ToString("0.00"); } }

        [InterfaceFieldPosition(7)]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string? Organization { get; set; }

        [InterfaceFieldPosition(8)]
        [StringLength(maximumLength: 6, MinimumLength = 6)]
        public string? Account { get; set; }

        [InterfaceFieldPosition(9)]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string? Fund { get; set; }

        [InterfaceFieldPosition(10)]
        [StringLength(maximumLength: 8, MinimumLength = 8)]
        public string? BudgetEntity { get; set; }

        [InterfaceFieldPosition(11)]
        [StringLength(maximumLength: 6, MinimumLength = 6)]
        public string? Category { get; set; }

        [InterfaceFieldPosition(12)]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string? StateProgram { get; set; }

        [InterfaceFieldPosition(13)]
        [StringLength(maximumLength: 5, MinimumLength = 1)]
        public string? Grant { get; set; }

        [InterfaceFieldPosition(14)]
        [StringLength(maximumLength: 10, MinimumLength = 1)]
        public string? Contract { get; set; }

        [InterfaceFieldPosition(15)]
        [StringLength(maximumLength: 5, MinimumLength = 1)]
        public string? OA1 { get; set; }

        [InterfaceFieldPosition(16)]
        [StringLength(maximumLength: 10, MinimumLength = 1)]
        public string? OA2 { get; set; }

        [InterfaceFieldPosition(17)]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string? PCBusinessUnit { get; set; }

        [InterfaceFieldPosition(18)]
        [StringLength(maximumLength: 15, MinimumLength = 1)]
        public string? Project { get; set; }

        [InterfaceFieldPosition(19)]
        [StringLength(maximumLength: 15, MinimumLength = 1)]
        public string? Activity { get; set; }

        [InterfaceFieldPosition(20)]
        [StringLength(maximumLength: 5, MinimumLength = 1)]
        public string? PCSourceType { get; set; }

        [InterfaceFieldPosition(21)]
        [StringLength(maximumLength: 5, MinimumLength = 1)]
        public string? PCCategory { get; set; }

        [InterfaceFieldPosition(22)]
        [StringLength(maximumLength: 5, MinimumLength = 1)]
        public string? PCSubcategory { get; set; }

        public DateOnly? BudgetDate { get; set; }
        [InterfaceFieldPosition(23)]
        internal string? BudgetDateFormatted => BudgetDate?.ToString("MM/dd/yyyy");

        [InterfaceFieldPosition(24)]
        [StringLength(maximumLength: 1, MinimumLength = 10)]
        public string? AssetProfileID { get; set; }

        [InterfaceFieldPosition(25)]
        [StringLength(maximumLength: 30)]
        public string? Filler1 { get; set; }

        [InterfaceFieldPosition(26)]
        [StringLength(maximumLength: 30)]
        public string? Filler2 { get; set; }

        [InterfaceFieldPosition(27)]
        [StringLength(maximumLength: 30)]
        public string? Filler3 { get; set; }

        [InterfaceFieldPosition(28)]
        [StringLength(maximumLength: 30)]
        public string? Filler4 { get; set; }

        [InterfaceFieldPosition(29)]
        [StringLength(maximumLength: 30)]
        public string? Filler5 { get; set; }

        [InterfaceFieldPosition(30)]
        [StringLength(maximumLength: 30)]
        public string? Filler6 { get; set; }

        [InterfaceFieldPosition(31)]
        [StringLength(maximumLength: 30)]
        public string? Filler7 { get; set; }

        [InterfaceFieldPosition(32)]
        [StringLength(maximumLength: 30)]
        public string? Filler8 { get; set; }

        [InterfaceFieldPosition(33)]
        [StringLength(maximumLength: 30)]
        public string? Filler9 { get; set; }

        [InterfaceFieldPosition(34)]
        [StringLength(maximumLength: 30)]
        public string? Filler10 { get; set; }
    }
}
