using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PALM.BatchInterfaceTools.Library.Constants.CommitmentControlConstants;

namespace PALM.BatchInterfaceTools.Library.Interfaces.CommitmentControl
{
    public interface IKKBudgetLine
    {
        public int JournalLineNumber { get; set; }
        public DateOnly BudgetPeriod { get; set; }
        public string? Organization { get; set; }
        public string Account { get; set; }
        public string Fund { get; set; }
        public string BudgetEntity { get; set; }
        public string Category { get; set; }
        public string? StateProgram { get; set; }
        public string? Grant { get; set; }
        public string? Contract { get; set; }
        public string? OA1 { get; set; }
        public string? OA2 { get; set; }
        public string? PCBusinessUnit { get; set; }
        public string? Project { get; set; }
        public string? Activity { get; set; }
        public string? PCSourceType { get; set; }
        public decimal MonetaryAmount { get; set; }
        public JournalClassValues? JournalClass { get; set; }
        public string? JournalLineReference { get; set; }
        public string? JournalLineReferenceDescription { get; set; }
    }
}
