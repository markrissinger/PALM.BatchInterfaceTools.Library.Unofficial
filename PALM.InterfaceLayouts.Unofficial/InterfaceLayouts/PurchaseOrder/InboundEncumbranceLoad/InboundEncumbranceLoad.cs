using PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrder.InboundEncumbranceLoad;
using PALM.InterfaceLayouts.Unofficial.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PALM.InterfaceLayouts.Unofficial.InterfaceLayouts.PurchaseOrders.InboundEncumbranceLoad
{
    /// <summary>
    /// Details: https://myfloridacfofloridapalm.us.document360.io/docs/inbound-encumbrance-load-poi002
    /// </summary>
    public class InboundEncumbranceLoad : IInterfaceLayout
    {
        public InboundEncumbranceLoad() 
        {
            POHeaders = new List<POHeaderDetails>();
            InterfaceID = "POI002";
        }
        public string InterfaceID { get; private set; }

        public List<POHeaderDetails> POHeaders { get; set; }

        private static readonly List<PropertyInfo> _poHeaderProperties = Helper.ExtractInterfaceFieldProperties<POHeaderDetails>();
        private static readonly List<PropertyInfo> _poLineProperties = Helper.ExtractInterfaceFieldProperties<POLineDetails>();
        private static readonly List<PropertyInfo> _poShipDetailsProperties = Helper.ExtractInterfaceFieldProperties<POLineShipDetails>();
        private static readonly List<PropertyInfo> _poDistributionLineProperties = Helper.ExtractInterfaceFieldProperties<PODistributionDetails>();

        /// <summary>
        /// Method to convert the Purchase Order records to a 
        /// StringBuilder so that it can be easily handled further on.
        /// </summary>
        /// <returns></returns>
        public StringBuilder ConvertRecordsToStringBuilder()
        {
            var sb = new StringBuilder();

            foreach (var POHeader in POHeaders)
            {
                sb.AppendLine(Helper.ComposeRecord(POHeader, _poHeaderProperties));

                foreach(var POLine in POHeader.POLines)
                {
                    sb.AppendLine(Helper.ComposeRecord(POLine, _poLineProperties));

                    if(POLine.POLineShipDetails != null)
                    {
                        sb.AppendLine(Helper.ComposeRecord(POLine.POLineShipDetails, _poShipDetailsProperties));
                    }

                    foreach(var PODistributionLine in POLine.PODistributionDetails)
                    {
                        sb.AppendLine(Helper.ComposeRecord(PODistributionLine, _poDistributionLineProperties));
                    }
                }
            }

            return sb;
        }

        /// <summary>
        /// Method to convert the Purchase Order records to a 
        /// byte array so that it can be easily handled further on.
        /// </summary>
        /// <returns></returns>
        public byte[] ConvertRecordsToByteArray()
        {
            return Encoding.ASCII.GetBytes(ConvertRecordsToStringBuilder().ToString());
        }
    }
}