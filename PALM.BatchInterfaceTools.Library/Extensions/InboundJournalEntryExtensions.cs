using PALM.BatchInterfaceTools.Library.Entities.CommitmentControl.InboundBudgetJournal;
using PALM.BatchInterfaceTools.Library.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALM.BatchInterfaceTools.Library.Extensions
{
    public static class InboundJournalEntryExtensions
    {
        /// <summary>
        /// Convert a list of Budget Header records to a StringBuilder.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of KKBudgetHeader</typeparam>
        /// <param name="BudgetHeaders">List of KKBudgetHeaders to convert to StringBuidler.</param>
        /// <returns>StringBuilder based on the Budget Header records.</returns>
        public static StringBuilder WriteRecordsToStringBuilder<T>(this IEnumerable<T> BudgetHeaders) where T : KKBudgetHeader
        {
            var sb = new StringBuilder();

            foreach (var budgetHeader in BudgetHeaders)
            {
                sb.AppendLine(Helper.ComposeRecord(budgetHeader, CommitmentControlPropertyHelpers.KKBudgetHeaderProperties));

                foreach (var budgetLine in budgetHeader.KKBudgetLines)
                {
                    sb.AppendLine(Helper.ComposeRecord(budgetLine, CommitmentControlPropertyHelpers.KKBudgetLineProperties));
                }
            }

            return sb;
        }

        /// <summary>
        /// Convert a list of Budget Journals records to a byte array.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of KKBudgetHeader</typeparam>
        /// <param name="BudgetHeaders">List of KKBudgetHeader to convert to byte array.</param>
        /// <returns>Byte array based on the Budget Header records.</returns>
        public static byte[] WriteRecordsToByteArray<T>(this IEnumerable<T> BudgetHeaders) where T : KKBudgetHeader
        {
            return Encoding.ASCII.GetBytes(BudgetHeaders.WriteRecordsToStringBuilder().ToString());
        }

        /// <summary>
        /// Create a list of Budget Journals records to text file in PALM specified format.
        /// </summary>
        /// <typeparam name="T">Type limited to IEnumerable of KKBudgetHeader</typeparam>
        /// <param name="BudgetHeaders">List of KKBudgetHeader to enter into file.</param>
        /// <param name="filePath">File path including file name and extension.</param>
        public static void WriteRecordsToFile<T>(this IEnumerable<T> BudgetHeaders, string filePath) where T : KKBudgetHeader
        {
            byte[] fileContents = Encoding.ASCII.GetBytes(BudgetHeaders.WriteRecordsToStringBuilder().ToString());
            using (var fs = File.Create(filePath))
            {
                fs.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
