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

        //private List<POHeaderDetails> _poHeaderDetails;
        public List<POHeaderDetails> POHeaders { get; set; }
        //public POHeaderDetails CreatePOHeader()
        //{
        //    POHeaderDetails poHeaderDetails = new POHeaderDetails();
        //    _poHeaderDetails.Add(poHeaderDetails);
        //    return poHeaderDetails;
        //}

        /// <summary>
        /// Method to convert the Purchase Order records to a 
        /// StringBuilder so that it can be easily handled further on.
        /// </summary>
        /// <returns></returns>
        public StringBuilder ConvertRecordsToStringBuilder()
        {
            var sb = new StringBuilder();

            List<PropertyInfo> POHeaderProperties = Helper.ExtractInterfaceFieldProperties<POHeaderDetails>();
            List<PropertyInfo> POLineProperties = Helper.ExtractInterfaceFieldProperties<POLineDetails>();
            List<PropertyInfo> POShipDetailsProperties = Helper.ExtractInterfaceFieldProperties<POLineShipDetails>();
            List<PropertyInfo> PODistributionLineProperties = Helper.ExtractInterfaceFieldProperties<PODistributionDetails>();

            foreach (var POHeader in POHeaders)
            {
                sb.AppendLine(Helper.ComposeRecord(POHeader, POHeaderProperties));

                foreach(var POLine in POHeader.POLines)
                {
                    sb.AppendLine(Helper.ComposeRecord(POLine, POLineProperties));

                    if(POLine.POLineShipDetails != null)
                    {
                        sb.AppendLine(Helper.ComposeRecord(POLine.POLineShipDetails, POShipDetailsProperties));
                    }

                    foreach(var PODistributionLine in POLine.PODistributionDetails)
                    {
                        sb.AppendLine(Helper.ComposeRecord(PODistributionLine, PODistributionLineProperties));
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