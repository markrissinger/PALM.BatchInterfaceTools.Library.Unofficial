using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Constants
{
    public static class GeneralLedgerConstants
    {
        public const string InterfaceID = "GLI006";
        public enum AdjustingEntryValues { Y, N };
        public enum ReversalCodeValues { N, B, D, E, U, X };
        public enum SourceValues { CLW, ADJ, ACR, RED };
        public enum InterIntraUnitAnchorValues { Y, N };
    }
}
