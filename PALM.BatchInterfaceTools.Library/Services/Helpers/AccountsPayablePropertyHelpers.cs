using PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Services.Helpers
{
    /// <summary>
    /// Cotnains list of properties that should be used PALM interfaces for each of the Accounts Payable classes.
    /// </summary>
    public static class AccountsPayablePropertyHelpers
    {
        /// Locker to enforce double check locking singleton.
        private static object locker = new object();

        #region InboundVoucherLoad
        // Voucher Header Properties
        private static IEnumerable<PropertyInfo>? _voucherHeaderProperties;
        public static IEnumerable<PropertyInfo> VoucherHeaderProperties
        {
            get
            {
                if (_voucherHeaderProperties == null)
                {
                    lock (locker)
                    {
                        _voucherHeaderProperties ??= Helper.ExtractInterfaceFieldProperties<VoucherHeader>();
                    }
                }

                return _voucherHeaderProperties;
            }
        }

        // Voucher Line Properties
        private static IEnumerable<PropertyInfo>? _voucherLineProperties;
        public static IEnumerable<PropertyInfo> VoucherLineProperties
        {
            get
            {
                if (_voucherLineProperties == null)
                {
                    lock (locker)
                    {
                        _voucherLineProperties ??= Helper.ExtractInterfaceFieldProperties<VoucherLine>();
                    }
                }

                return _voucherLineProperties;
            }
        }

        // Voucher Distribution Properties
        private static IEnumerable<PropertyInfo>? _voucherDistributionProperties;
        public static IEnumerable<PropertyInfo> VoucherDistributionProperties
        {
            get
            {
                if (_voucherDistributionProperties == null)
                {
                    lock (locker)
                    {
                        _voucherDistributionProperties ??= Helper.ExtractInterfaceFieldProperties<VoucherDistribution>();
                    }
                }

                return _voucherDistributionProperties;
            }
        }

        // Voucher Supplier Properties
        private static IEnumerable<PropertyInfo>? _voucherSupplierProperties;
        public static IEnumerable<PropertyInfo> VoucherSupplierProperties
        {
            get
            {
                if (_voucherSupplierProperties == null)
                {
                    lock (locker)
                    {
                        _voucherSupplierProperties ??= Helper.ExtractInterfaceFieldProperties<VoucherSupplier>();
                    }
                }

                return _voucherSupplierProperties;
            }
        }

        // Voucher Payment Properties
        private static IEnumerable<PropertyInfo>? _voucherPaymentProperties;
        public static IEnumerable<PropertyInfo> VoucherPaymentProperties
        {
            get
            {
                if (_voucherPaymentProperties == null)
                {
                    lock (locker)
                    {
                        _voucherPaymentProperties ??= Helper.ExtractInterfaceFieldProperties<VoucherPayment>();
                    }
                }

                return _voucherPaymentProperties;
            }
        }
        #endregion
    }
}
