using PALM.BatchInterfaceTools.Library.Entities.CommitmentControl.InboundBudgetJournal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Services.Helpers
{
    public static class CommitmentControlPropertyHelpers
    {
        /// Locker to enforce double check locking singleton.
        private static object locker = new object();

        #region InboundBudgetJournal
        // Budget Header Properties
        private static IEnumerable<PropertyInfo>? _kkBudgetHeaderProperties;
        public static IEnumerable<PropertyInfo> KKBudgetHeaderProperties
        {
            get
            {
                if (_kkBudgetHeaderProperties == null)
                {
                    lock (locker)
                    {
                        _kkBudgetHeaderProperties ??= Helper.ExtractInterfaceFieldProperties<KKBudgetHeader>();
                    }
                }

                return _kkBudgetHeaderProperties;
            }
        }

        // Budget Line Properties
        private static IEnumerable<PropertyInfo>? _kkBudgetLineProperties;
        public static IEnumerable<PropertyInfo> KKBudgetLineProperties
        {
            get
            {
                if (_kkBudgetLineProperties == null)
                {
                    lock (locker)
                    {
                        _kkBudgetLineProperties ??= Helper.ExtractInterfaceFieldProperties<KKBudgetLine>();
                    }
                }

                return _kkBudgetLineProperties;
            }
        }
        #endregion
    }
}
