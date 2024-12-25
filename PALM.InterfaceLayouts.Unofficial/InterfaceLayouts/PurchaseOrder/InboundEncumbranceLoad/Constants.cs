using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad
{
    public static class Constants
    {
        public enum POHeaderActions { ADD, UPDATE, CANCEL, CLOSE, REOPEN, DELETE };
        public enum POLineActions { ADD, UPDATE };
        public enum PODistributionActions { ADD, UPDATE };
    }
}
