using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad
{
    public class VoucherDistribution : IRecordType, IVoucherDistribution
    {
        public VoucherDistribution() { }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "D"; } }

        [Required]
        [Range(0, 99999)]
        [InterfaceFieldPosition(2)]
        public int VoucherLineNumber { get; set; }

        [Required]
        [Range(0, 99999)]
        [InterfaceFieldPosition(3)]
        public int VoucherDistributionLineNumber { get; set; }

        [Required]
        public decimal? DistributionLineMerchandiseAmount { get; set; }
        [InterfaceFieldPosition(4)]
        internal string? DistributionLineMerchandiseAmountFormatted { get { return DistributionLineMerchandiseAmount?.ToString("0.00"); } }

        public decimal? DistributionLineQuantity { get; set; }
        [InterfaceFieldPosition(5)]
        internal string? DistributionLineQuantityFormatted { get { return DistributionLineQuantity?.ToString("#.###"); } }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(6)]
        public string? GLBusinessUnit { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [InterfaceFieldPosition(7)]
        public string? Organization { get; set; }

        [StringLength(maximumLength: 6, MinimumLength = 6)]
        [InterfaceFieldPosition(8)]
        public string? Account { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(9)]
        public string? Fund { get; set; }

        [StringLength(maximumLength: 8, MinimumLength = 8)]
        [InterfaceFieldPosition(10)]
        public string? BudgetEntity { get; set; }

        [StringLength(maximumLength: 6, MinimumLength = 6)]
        [InterfaceFieldPosition(11)]
        public string? Category { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [InterfaceFieldPosition(12)]
        public string? StateProgram { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(13)]
        public string? Grant { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 1)]
        [InterfaceFieldPosition(14)]
        public string? Contract { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(15)]
        public string? OA1 { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 1)]
        [InterfaceFieldPosition(16)]
        public string? OA2 { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(17)]
        public string? PCBusinessUnit { get; set; }

        [StringLength(maximumLength: 15, MinimumLength = 1)]
        [InterfaceFieldPosition(18)]
        public string? Project { get; set; }

        [StringLength(maximumLength: 15, MinimumLength = 1)]
        [InterfaceFieldPosition(19)]
        public string? Activity { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(20)]
        public string? PCSourceType { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(21)]
        public string? PCCategory { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(22)]
        public string? Subcategory { get; set; }

        [Required]
        public DateOnly? BudgetDate { get; set; }
        [InterfaceFieldPosition(23)]
        internal string? BudgetDateFormatted { get { return BudgetDate?.ToString("MM/dd/yyyy"); } }

        [Range(0, 99999)]
        [InterfaceFieldPosition(24)]
        public int? POLineNumber { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(25)]
        public int? PODistributionLineNumber { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(26)]
        public int? ReceiptLineNumber { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(27)]
        public int? ReceiptDistributionLineNumber { get; set; }

        [StringLength(maximumLength: 100)]
        [InterfaceFieldPosition(28)]
        public string? AssetIDReference { get; set; }

        public AssetFlagValues? AssetFlag { get; set; }
        [InterfaceFieldPosition(29)]
        internal string? AssetFlagFormatted { get { return AssetFlag.HasValue ? Enum.GetName(typeof(AssetFlagValues), AssetFlag) : string.Empty; } }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(30)]
        public string? AMBusinessUnit { get; set; }

        [StringLength(maximumLength: 12)]
        [InterfaceFieldPosition(31)]
        public string? AssetID { get; set; }

        [StringLength(maximumLength: 10)]
        [InterfaceFieldPosition(32)]
        public string? ProfileID { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(33)]
        public string? Filler1 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(34)]
        public string? Filler2 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(35)]
        public string? Filler3 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(36)]
        public string? Filler4 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(37)]
        public string? Filler5 { get; set; }
    }
}
