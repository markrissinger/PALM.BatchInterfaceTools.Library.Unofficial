using PALM.BatchInterfaceTools.Library.Entities.AccountsPayables.InboundVoucherLoad;
using PALM.BatchInterfaceTools.Library.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Extensions
{
    public static class InboundVoucherLoadExtensions
    {
        /// <summary>
        /// Convert a list of VoucherHeader records to a StringBuilder.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of VoucherHeader</typeparam>
        /// <param name="VoucherHeaders">List of VoucherHeader to convert to StringBuidler.</param>
        /// <param name="includeSupplierRecords">Indicate if the method should generate Supplier records (could contian sensitive information).</param>
        /// <returns>StringBuilder based on the VoucherHeader records.</returns>
        /// <summary>
        public static StringBuilder WriteRecordsToStringBuilder<T>(this IEnumerable<T> VoucherHeaders, bool includeSupplierRecords = true) where T : VoucherHeader
        {
            var sb = new StringBuilder();

            foreach (var voucherHeader in VoucherHeaders)
            {
                sb.AppendLine(Helper.ComposeRecord(voucherHeader, AccountsPayablePropertyHelpers.VoucherHeaderProperties));

                // check whether to include supplier records
                if (includeSupplierRecords)
                {
                    if (voucherHeader.VoucherSupplier != null)
                    {
                        sb.AppendLine(Helper.ComposeRecord(voucherHeader.VoucherSupplier, AccountsPayablePropertyHelpers.VoucherSupplierProperties));
                    }
                }                

                sb.AppendLine(Helper.ComposeRecord(voucherHeader.VoucherPayment, AccountsPayablePropertyHelpers.VoucherPaymentProperties));

                foreach (var voucherLine in voucherHeader.VoucherLines)
                {
                    sb.AppendLine(Helper.ComposeRecord(voucherLine, AccountsPayablePropertyHelpers.VoucherLineProperties));

                    foreach (var voucherDistribution in voucherLine.VoucherDistributions)
                    {
                        sb.AppendLine(Helper.ComposeRecord(voucherDistribution, AccountsPayablePropertyHelpers.VoucherDistributionProperties));
                    }
                }
            }

            return sb;
        }

        /// <summary>
        /// Convert a list of VoucherHeader records to a byte array.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of VoucherHeader</typeparam>
        /// <param name="POHeaders">List of VoucherHeader to convert to byte array.</param>
        /// <returns>Byte array based on the VoucherHeader records.</returns>
        public static byte[] WriteRecordsToByteArray<T>(this IEnumerable<T> VoucherHeaders) where T : VoucherHeader
        {
            return Encoding.ASCII.GetBytes(VoucherHeaders.WriteRecordsToStringBuilder().ToString());
        }

        /// <summary>
        /// Create a list of VoucherHeader records to text file in PALM specified format.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of VoucherHeader</typeparam>
        /// <param name="POHeaders">List of VoucherHeader to enter into file.</param>
        /// <param name="filePath">File path including file name and extension.</param>
        public static void WriteRecordsToFile<T>(this IEnumerable<T> VoucherHeaders, string filePath) where T : VoucherHeader
        {
            byte[] fileContents = Encoding.ASCII.GetBytes(VoucherHeaders.WriteRecordsToStringBuilder().ToString());
            using (var fs = File.Create(filePath))
            {
                fs.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
