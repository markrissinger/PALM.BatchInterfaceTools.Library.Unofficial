using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.CommitmentControlConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.CommitmentControl
{
    public interface IKKBudgetHeader
    {
        public string BusinessUnit { get; set; }
        public DateOnly JournalDate { get; set; }
        public string? LongDescription { get; set; }
        public LedgerGroupValues LedgerGroup { get; set; }
        public string BudgetEntryType { get; set; }
        public string? AlternateDescription { get; set; }
    }
}
