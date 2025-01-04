using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.AccountsPayableConstants;

namespace PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad
{
    public class VoucherLine : IRecordType, IVoucherLine
    {
        public VoucherLine()
        {
            VoucherDistributions = [];
        }

        #region Children
        public List<VoucherDistribution> VoucherDistributions { get; set; }
        #endregion

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "L"; } }

        [Required]
        [Range(0, 99999)]
        [InterfaceFieldPosition(2)]
        public int VoucherLineNumber { get; set; }

        [StringLength(maximumLength: 254)]
        [InterfaceFieldPosition(3)]
        public string? LineDescription { get; set; }

        public decimal? Quantity { get; set; }
        [InterfaceFieldPosition(4)]
        internal string? QuantityFormatted { get { return Quantity?.ToString("#.###"); } }

        [StringLength(maximumLength: 3)]
        [InterfaceFieldPosition(5)]
        public string? UnitofMeasure { get; set; }

        public decimal? Price { get; set; }
        [InterfaceFieldPosition(6)]
        internal string? PriceFormatted { get { return Price?.ToString("0.00"); } }

        public decimal? MerchandiseAmount { get; set; }
        [InterfaceFieldPosition(7)]
        internal string? MerchandiseAmountFormatted { get { return MerchandiseAmount?.ToString("0.00"); } }

        [StringLength(maximumLength: 8)]
        [InterfaceFieldPosition(8)]
        public string? RelatedVoucher { get; set; }

        [Required]
        public DistributionMethodValues DistributionMethod { get; set; }
        [InterfaceFieldPosition(9)]
        internal string? DistributionMethodFormatted { get { return Enum.GetName(typeof(DistributionMethodValues), DistributionMethod); } }

        [StringLength(maximumLength: 10)]
        [InterfaceFieldPosition(10)]
        public string? ShipToLocation { get; set; }

        [StringLength(maximumLength: 100)]
        [InterfaceFieldPosition(11)]
        public string? Merchant { get; set; }

        [StringLength(maximumLength: 100)]
        [InterfaceFieldPosition(12)]
        public string? Traveler { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(13)]
        public string? POBusinessUnit { get; set; }

        [StringLength(maximumLength: 10)]
        [InterfaceFieldPosition(14)]
        public string? POID { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(15)]
        public int? POLineNumber { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(16)]
        public string? ReceiptBusinessUnit { get; set; }

        [StringLength(maximumLength: 10)]
        [InterfaceFieldPosition(17)]
        public string? ReceiptID { get; set; }

        [Range(0, 99999)]
        [InterfaceFieldPosition(18)]
        public int? ReceiptLineNumber { get; set; }

        [StringLength(maximumLength: 22)]
        [InterfaceFieldPosition(19)]
        public string? DocumentNumber { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(20)]
        public string? Filler1 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(21)]
        public string? Filler2 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(22)]
        public string? Filler3 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(23)]
        public string? Filler4 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(24)]
        public string? Filler5 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(25)]
        public string? Filler6 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(26)]
        public string? Filler7 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(27)]
        public string? Filler8 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(28)]
        public string? Filler9 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(29)]
        public string? Filler10 { get; set; }
    }
}
