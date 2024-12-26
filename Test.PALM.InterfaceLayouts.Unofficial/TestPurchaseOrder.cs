using PALM.InterfaceLayouts.Unofficial.Constants;
using PALM.InterfaceLayouts.Unofficial.Entities.InterfaceLayouts.PurchaseOrders.InboundEncumbranceLoad;
using System.Text;

namespace Test.PALM.InterfaceLayouts.Unofficial
{
    public class TestPurchaseOrder
    {
        [Fact]
        public void TestInboundEncumbranceLoad()
        {
            InboundEncumbranceLoad inboundEncumbranceLoad = CreateMockInboundEncumbranceLoad();
            StringBuilder sb = inboundEncumbranceLoad.ConvertRecordsToStringBuilder();

            Assert.True(sb.Length > 0);
        }

        private InboundEncumbranceLoad CreateMockInboundEncumbranceLoad()
        {
            InboundEncumbranceLoad inboundEncumbranceLoad = new();
            inboundEncumbranceLoad.POHeaders.Add(CreateMockPOHeaderDetails());
            inboundEncumbranceLoad.POHeaders.Add(CreateMockPOHeaderDetails());

            return inboundEncumbranceLoad;
        }

        private POHeaderDetails CreateMockPOHeaderDetails()
        {
            POHeaderDetails poHeaderDetails = new();
            poHeaderDetails.POHeaderAction = PurchaseOrdersConstants.POHeaderActions.ADD;
            poHeaderDetails.BusinessUnit = "55000";
            poHeaderDetails.POID = "NEXT";
            poHeaderDetails.PODate = new DateOnly(2024, 12, 25);

            poHeaderDetails.POLines.Add(CreateMockPOLineDetails());
            poHeaderDetails.POLines.Add(CreateMockPOLineDetails());

            return poHeaderDetails;
        }
        private POLineDetails CreateMockPOLineDetails()
        {
            POLineDetails poLineDetails = new();
            poLineDetails.POLineAction = PurchaseOrdersConstants.POLineActions.ADD;
            poLineDetails.LineNumber = new Random().Next(1, 999);

            poLineDetails.POLineShipDetails = CreateMockPOLineShipDetails();
            poLineDetails.PODistributionDetails.Add(CreateMockPODistributionDetails());
            poLineDetails.PODistributionDetails.Add(CreateMockPODistributionDetails());

            return poLineDetails;
        }
        private POLineShipDetails CreateMockPOLineShipDetails()
        {
            POLineShipDetails poLineShipDetails = new();
            poLineShipDetails.POQuantity = 1.01m;
            poLineShipDetails.POTotalLineAmount = 100.01m;

            return poLineShipDetails;
        }
        private PODistributionDetails CreateMockPODistributionDetails()
        {
            PODistributionDetails poDistributionDetails = new();
            poDistributionDetails.PODistributionAction = PurchaseOrdersConstants.PODistributionActions.ADD; 
            poDistributionDetails.DistributionLineNumber = new Random().Next(1, 999);
            poDistributionDetails.Organization = "5512345678";
            poDistributionDetails.Account = "123456";
            poDistributionDetails.Fund = "12345";
            poDistributionDetails.BudgetEntity = "12345678";
            poDistributionDetails.Category = "123456";
            poDistributionDetails.StateProgram = "";

            return poDistributionDetails;
        }
    }
}