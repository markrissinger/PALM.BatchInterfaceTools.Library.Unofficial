using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Constants
{
    public static class PurchaseOrdersConstants
    {
        public const string InterfaceID = "POI002";
        public enum POHeaderActionValues { ADD, UPDATE, CANCEL, CLOSE, REOPEN, DELETE };
        public enum POLineActionValues { ADD, UPDATE };
        public enum PODistributionActionValues { ADD, UPDATE };
    }
}
