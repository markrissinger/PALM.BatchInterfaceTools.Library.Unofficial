using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Interfaces;
using PALM.BatchInterfaceTools.Library.Interfaces.CommitmentControl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.CommitmentControlConstants;

namespace PALM.BatchInterfaceTools.Library.Entities.CommitmentControl.InboundBudgetJournal
{
    public class KKBudgetLine : IRecordType, IKKBudgetLine
    {
        public KKBudgetLine() { }

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "H"; } }

        [Required]
        [Range(0, 99999)]
        [InterfaceFieldPosition(2)]
        public int JournalLineNumber { get; set; }

        [Required]
        public DateOnly BudgetPeriod { get; set; }
        [InterfaceFieldPosition(3)]
        internal string BudgetPeriodFormatted { get { return BudgetPeriod.ToString("MM/dd/yyyy"); } }

        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [InterfaceFieldPosition(4)]
        public string? Organization { get; set; }

        [Required]
        [StringLength(maximumLength: 6, MinimumLength = 6)]
        [InterfaceFieldPosition(5)]
        public string? Account { get; set; }

        [Required]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(6)]
        public string? Fund { get; set; }

        [Required]
        [StringLength(maximumLength: 8, MinimumLength = 8)]
        [InterfaceFieldPosition(7)]
        public string? BudgetEntity { get; set; }

        [Required]
        [StringLength(maximumLength: 6, MinimumLength = 6)]
        [InterfaceFieldPosition(8)]
        public string? Category { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 10)]
        [InterfaceFieldPosition(9)]
        public string? StateProgram { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(10)]
        public string? Grant { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 1)]
        [InterfaceFieldPosition(11)]
        public string? Contract { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(12)]
        public string? OA1 { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 1)]
        [InterfaceFieldPosition(13)]
        public string? OA2 { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 5)]
        [InterfaceFieldPosition(14)]
        public string? PCBusinessUnit { get; set; }

        [StringLength(maximumLength: 15, MinimumLength = 1)]
        [InterfaceFieldPosition(15)]
        public string? Project { get; set; }

        [StringLength(maximumLength: 15, MinimumLength = 1)]
        [InterfaceFieldPosition(16)]
        public string? Activity { get; set; }

        [StringLength(maximumLength: 5, MinimumLength = 1)]
        [InterfaceFieldPosition(17)]
        public string? PCSourceType { get; set; }

        [Required]
        [InterfaceFieldPosition(18)]
        public decimal MonetaryAmount { get; set; }

        [InterfaceFieldPosition(19)]
        public JournalClassValues? JournalClass { get; set; }
        internal string? JournalClassFormatted { get { return JournalClass.HasValue ? Enum.GetName(typeof(JournalClassValues), JournalClass) : string.Empty; } }

        [StringLength(maximumLength: 10, MinimumLength = 1)]
        [InterfaceFieldPosition(20)]
        public string? JournalLineReference { get; set; }

        [StringLength(maximumLength: 30)]
        [InterfaceFieldPosition(21)]
        public string? JournalLineReferenceDescription { get; set; }
    }
}
