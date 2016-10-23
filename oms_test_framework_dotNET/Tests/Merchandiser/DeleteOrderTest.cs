using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System.Threading;

namespace oms_test_framework_dotNET.Tests.Merchandiser
{
    [TestClass]
    public class DeleteOrderTest : TestRunner
    {
        private Order testOrder;
        private int testOrderId;
        private int testOrderItemId;

        [TestInitialize]
        public void SetUp()
        {
            testOrderId = TestHelper.CreateValidOrderInDB();
            testOrder = DBOrderHandler.GetOrderById(testOrderId);
            testOrderItemId = TestHelper.CreateOrderItemInDB();
            userInfoPage = logInPage.LogInAs(Roles.MERCHANDISER);
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
        }

        [TestMethod]
        public void TestOrdersElementsPresence()
        {
            merchandiserOrderingPage
                .SelectSearchDropdown("Order Name")
                .FillSearchInput(testOrder.OrderName)
                .ClickApplyButton();

            Assert.IsTrue(merchandiserOrderingPage
                .FirstOrderNameCell
                .Text
                .Equals(testOrder.OrderName), "Order is not present");

            Assert.IsTrue(merchandiserOrderingPage
                .FirstOrderDeleteCell.Displayed, "Link delete order is not present");
        }

        [TestMethod]
        public void TestDeleteOrderAndClickCancel()
        {
            merchandiserOrderingPage
                .SelectSearchDropdown("Order Name")
                .FillSearchInput(testOrder.OrderName)
                .ClickApplyButton();

            merchandiserOrderingPage
                .ClickDeleteFirstOrderLink()
                .DismissAlert();

            Assert.IsTrue(DBOrderHandler
                .GetOrderByNumber(testOrder.OrderNumber)
                .OrderNumber
                .Equals(testOrder.OrderNumber), "Order has been deleted");
        }

        [TestMethod]
        public void TestDeleteOrderAndClickConfirm()
        {
            merchandiserOrderingPage
                .SelectSearchDropdown("Order Name")
                .FillSearchInput(testOrder.OrderName)
                .ClickApplyButton();

            merchandiserOrderingPage
                .ClickDeleteFirstOrderLink()
                .AcceptAlert();

            Thread.Sleep(1000);

            Assert.IsTrue(DBOrderHandler
                .GetOrderByNumber(testOrder.OrderNumber) == null, "Deleted order still exists!");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderItemHandler.DeleteOrderItemById(testOrderItemId);
        }
    }
}
