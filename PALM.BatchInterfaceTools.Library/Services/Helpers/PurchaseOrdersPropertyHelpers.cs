﻿using PALM.BatchInterfaceTools.Library.Entities.PurchaseOrders.InboundEncumbranceLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Services.Helpers
{
    /// <summary>
    /// Cotnains list of properties that should be used PALM interfaces for each of the Purchase Order classes.
    /// </summary>
    public static class PurchaseOrdersPropertyHelpers
    {
        /// Locker to enforce double check locking singleton.
        private static object locker = new object();

        #region InboundEncumbranceLoad
        // PO Header Properties
        private static IEnumerable<PropertyInfo>? _poHeaderProperties;
        public static IEnumerable<PropertyInfo> POHeaderProperties
        {
            get
            {
                if (_poHeaderProperties == null)
                {
                    lock (locker)
                    {
                        _poHeaderProperties ??= Helper.ExtractInterfaceFieldProperties<POHeaderDetails>();
                    }
                }

                return _poHeaderProperties;
            }
        }

        // PO Line Properties
        private static IEnumerable<PropertyInfo>? _poLineProperties;
        public static IEnumerable<PropertyInfo> POLineProperties
        {
            get
            {
                if (_poLineProperties == null)
                {
                    lock (locker)
                    {
                        _poLineProperties ??= Helper.ExtractInterfaceFieldProperties<POLineDetails>();
                    }
                }

                return _poLineProperties;
            }
        }

        // PO Ship Properties
        private static IEnumerable<PropertyInfo>? _poShipDetailsProperties;
        public static IEnumerable<PropertyInfo> POShipDetailsProperties
        {
            get
            {
                if (_poShipDetailsProperties == null)
                {
                    lock (locker)
                    {
                        _poShipDetailsProperties ??= Helper.ExtractInterfaceFieldProperties<POLineShipDetails>();
                    }
                }

                return _poShipDetailsProperties;
            }
        }

        // PO Distribution Properties
        private static IEnumerable<PropertyInfo>? _poDistributionLineProperties;
        public static IEnumerable<PropertyInfo> PODistributionLineProperties
        {
            get
            {
                if (_poDistributionLineProperties == null)
                {
                    lock (locker)
                    {
                        _poDistributionLineProperties ??= Helper.ExtractInterfaceFieldProperties<PODistributionDetails>();
                    }
                }

                return _poDistributionLineProperties;
            }
        }
        #endregion
    }
}