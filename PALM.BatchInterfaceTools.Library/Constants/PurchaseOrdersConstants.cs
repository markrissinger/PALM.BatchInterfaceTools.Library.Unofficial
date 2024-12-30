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
        public enum POHeaderActions { ADD, UPDATE, CANCEL, CLOSE, REOPEN, DELETE };
        public enum POLineActions { ADD, UPDATE };
        public enum PODistributionActions { ADD, UPDATE };
    }
}
