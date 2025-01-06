using PALM.BatchInterfaceTools.Library.Attributes;
using PALM.BatchInterfaceTools.Library.Constants;
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
    public class KKBudgetHeader : IRecordType, IKKBudgetHeader
    {
        public KKBudgetHeader() 
        {
            KKBudgetLines = [];
        }

        #region Children
        public List<KKBudgetLine> KKBudgetLines { get; set; }
        #endregion

        [InterfaceFieldPosition(1)]
        public static string RecordCode { get { return "H"; } }

        [Required]
        [InterfaceFieldPosition(2)]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string BusinessUnit { get; set; }

        [Required]
        public DateOnly JournalDate { get; set; }
        [InterfaceFieldPosition(3)]
        internal string? JournalDateFormatted { get { return JournalDate.ToString("MM/dd/yyyy"); } }

        [StringLength(maximumLength: 254)]
        [InterfaceFieldPosition(4)]
        public string? LongDescription { get; set; }

        [Required]
        public LedgerGroupValues LedgerGroup { get; set; }
        [InterfaceFieldPosition(5)]
        internal string LedgerGroupFormatted { get { return Enum.GetName(typeof(LedgerGroupValues), LedgerGroup); } }


        [Required]
        [StringLength(maximumLength: 1)]
        [InterfaceFieldPosition(6)]
        public string BudgetEntryType { get; set; }

        [StringLength(maximumLength: 150)]
        [InterfaceFieldPosition(7)]
        public string? AlternateDescription { get; set; }
    }
}
