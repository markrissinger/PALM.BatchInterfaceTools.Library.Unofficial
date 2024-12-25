using PALM.InterfaceLayouts.Unofficial.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad.Constants;

namespace PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad
{
    public class PODistributionDetails : IRecordType
    {
        public PODistributionDetails()
        {
        }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "D"; } }

        [Required]
        public PODistributionActions PODistributionAction { get; set; }
        [InterfaceFieldPosition(2)]
        internal string? PODistributionActionFormatted { get { return Enum.GetName(typeof(PODistributionActions), PODistributionAction); } }

        [Required]
        [InterfaceFieldPosition(3)]
        public int DistributionLineNumber { get; set; }

        public decimal? DistributionPOQuantity { get; set; }
        [InterfaceFieldPosition(4)]
        public string? DistributionPOQuantityFormatted { get { return DistributionPOQuantity?.ToString("#.###"); } }

        public decimal? DistributionPercentage { get; set; }
        [InterfaceFieldPosition(5)]
        internal string? DistributionPercentageFormatted { get { return DistributionPercentage?.ToString("#.##"); } }

        public decimal? DistributionLineMerchandiseAmount { get; set; }
        [InterfaceFieldPosition(6)]
        internal string? DistributionLineMerchandiseAmountFormatted { get { return DistributionLineMerchandiseAmount?.ToString("#.##"); } }

        [Required]
        [InterfaceFieldPosition(7)]
        public string? Organization { get; set; }

        [Required]
        [InterfaceFieldPosition(8)]
        public string? Account {  get; set; }

        [Required]
        [InterfaceFieldPosition(9)]
        public string? Fund { get; set; }

        [Required]
        [InterfaceFieldPosition(10)]
        public string? BudgetEntity { get; set; }

        [Required]
        [InterfaceFieldPosition(11)]
        public string? Category { get; set; }

        [Required]
        [InterfaceFieldPosition(12)]
        public string? StateProgram { get; set; }

        [InterfaceFieldPosition(13)]
        public string? Grant { get; set; }

        [InterfaceFieldPosition(14)]
        public string? OA1 { get; set; }

        [InterfaceFieldPosition(15)]
        public string? OA2 { get; set; }

        [InterfaceFieldPosition(16)]
        public string? PCBusinessUnit { get; set; }

        [InterfaceFieldPosition(17)]
        public string? Project { get; set; }

        [InterfaceFieldPosition(18)]
        public string? Activity { get; set; }

        [InterfaceFieldPosition(19)]
        public string? PCSourceType { get; set; }

        [InterfaceFieldPosition(20)]
        public string? PCCategory { get; set; }

        [InterfaceFieldPosition(21)]
        public string? PCSubcategory { get; set; }

        public DateOnly? BudgetDate { get; set; }
        [InterfaceFieldPosition(22)]
        internal string? BudgetDateFormatted => BudgetDate?.ToString("MM/dd/yyyy");

        [InterfaceFieldPosition(23)]
        public string? AssetProfileID { get; set; }

        [InterfaceFieldPosition(24)]
        [StringLength(maximumLength: 30)]
        public string? Filler1 { get; set; }

        [InterfaceFieldPosition(25)]
        [StringLength(maximumLength: 30)]
        public string? Filler2 { get; set; }

        [InterfaceFieldPosition(26)]
        [StringLength(maximumLength: 30)]
        public string? Filler3 { get; set; }

        [InterfaceFieldPosition(27)]
        [StringLength(maximumLength: 30)]
        public string? Filler4 { get; set; }

        [InterfaceFieldPosition(28)]
        [StringLength(maximumLength: 30)]
        public string? Filler5 { get; set; }

        [InterfaceFieldPosition(29)]
        [StringLength(maximumLength: 30)]
        public string? Filler6 { get; set; }

        [InterfaceFieldPosition(30)]
        [StringLength(maximumLength: 30)]
        public string? Filler7 { get; set; }

        [InterfaceFieldPosition(31)]
        [StringLength(maximumLength: 30)]
        public string? Filler8 { get; set; }

        [InterfaceFieldPosition(32)]
        [StringLength(maximumLength: 30)]
        public string? Filler9 { get; set; }

        [InterfaceFieldPosition(33)]
        [StringLength(maximumLength: 30)]
        public string? Filler10 { get; set; }
    }
}
