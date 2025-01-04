using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.AccountsPayable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad
{
    /// <summary>
    /// Intentionally keeping this class internal since it may contain sensitive information.
    /// </summary>
    public class VoucherSupplier : IRecordType, IVoucherSupplier
    {
        public VoucherSupplier() { }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "S"; } }

        [Required]
        [StringLength(maximumLength: 40)]
        [InterfaceFieldPosition(2)]
        public string? Name1 { get; set; }

        [Required]
        [StringLength(maximumLength: 3)]
        [InterfaceFieldPosition(3)]
        public string? Country { get; set; }

        [Required]
        [StringLength(maximumLength: 55)]
        [InterfaceFieldPosition(4)]
        public string? Address1 { get; set; }

        [StringLength(maximumLength: 55)]
        [InterfaceFieldPosition(5)]
        public string? Address2 { get; set; }

        [StringLength(maximumLength: 55)]
        [InterfaceFieldPosition(6)]
        public string? Address3 { get; set; }

        [StringLength(maximumLength: 55)]
        [InterfaceFieldPosition(7)]
        public string? Address4 { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(8)]
        public string? City { get; set; }

        [Required]
        [StringLength(maximumLength: 6)]
        [InterfaceFieldPosition(9)]
        public string? State { get; set; }

        [Required]
        [StringLength(maximumLength: 12)]
        [InterfaceFieldPosition(10)]
        public string? PostalCode { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(11)]
        public string? Filler1 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(12)]
        public string? Filler2 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(13)]
        public string? Filler3 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(14)]
        public string? Filler4 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(15)]
        public string? Filler5 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(16)]
        public string? Filler6 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(17)]
        public string? Filler7 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(18)]
        public string? Filler8 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(19)]
        public string? Filler9 { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(20)]
        public string? Filler10 { get; set; }
    }
}
