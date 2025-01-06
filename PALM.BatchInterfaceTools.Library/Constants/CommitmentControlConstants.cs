using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Constants
{
    public static class CommitmentControlConstants
    {
        public enum LedgerGroupValues { CC_APPROP, CC_RELEASE, CC_RESERVE, ALOT_XXXXX, CC_REVENUE }

        public enum JournalClassValues { Mandatory, Unbudgeted, Valid }
    }
}
