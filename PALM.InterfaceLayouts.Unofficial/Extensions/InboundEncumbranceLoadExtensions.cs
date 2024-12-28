using PALM.InterfaceLayouts.Unofficial.Entities.PurchaseOrders.InboundEncumbranceLoad;
using PALM.InterfaceLayouts.Unofficial.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.Extensions
{
    public static class InboundEncumbranceLoadExtensions
    {
        /// <summary>
        /// Convert a list of PO Header records to a StringBuilder.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of POHeaderDetails</typeparam>
        /// <param name="POHeaders">List of POHeaderDetails to convert to StringBuidler.</param>
        /// <returns>StringBuilder based on the PO Header records.</returns>
        public static StringBuilder WriteRecordsToStringBuilder<T>(this IEnumerable<T> POHeaders) where T : POHeaderDetails
        {
            var sb = new StringBuilder();

            foreach (var POHeader in POHeaders)
            {
                sb.AppendLine(Helper.ComposeRecord(POHeader, PurchaseOrdersPropertyHelpers.POHeaderProperties));

                foreach (var POLine in POHeader.POLines)
                {
                    sb.AppendLine(Helper.ComposeRecord(POLine, PurchaseOrdersPropertyHelpers.POLineProperties));

                    if (POLine.POLineShipDetails != null)
                    {
                        sb.AppendLine(Helper.ComposeRecord(POLine.POLineShipDetails, PurchaseOrdersPropertyHelpers.POShipDetailsProperties));
                    }

                    foreach (var PODistributionLine in POLine.PODistributionDetails)
                    {
                        sb.AppendLine(Helper.ComposeRecord(PODistributionLine, PurchaseOrdersPropertyHelpers.PODistributionLineProperties));
                    }
                }
            }

            return sb;
        }

        /// <summary>
        /// Convert a list of PO Header records to a byte array.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of POHeaderDetails</typeparam>
        /// <param name="POHeaders">List of POHeaderDetails to convert to byte array.</param>
        /// <returns>Byte array based on the PO Header records.</returns>
        public static byte[] WriteRecordsToByteArray<T> (this IEnumerable<T> POHeaders) where T : POHeaderDetails
        {
            return Encoding.ASCII.GetBytes(POHeaders.WriteRecordsToStringBuilder().ToString());
        }

        /// <summary>
        /// Create a list of PO Header records to text file in PALM specified format.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of POHeaderDetails</typeparam>
        /// <param name="POHeaders">List of POHeaderDetails to enter into file.</param>
        /// <param name="filePath">File path including file name and extension.</param>
        public static void WriteRecordsToFile<T>(this IEnumerable<T> POHeaders, string filePath) where T: POHeaderDetails
        {
            byte[] fileContents = Encoding.ASCII.GetBytes(POHeaders.WriteRecordsToStringBuilder().ToString());
            using (var fs = File.Create(filePath))
            {
                fs.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
