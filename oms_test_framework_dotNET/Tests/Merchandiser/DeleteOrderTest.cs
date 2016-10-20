using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Utils;
using System;

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
            const String MerchandiserLogin = "login1";
            const String MerchandiserPassword = "qwerty";
            testOrderId = TestUtil.CreateValidOrderInDB();
            testOrder = DBOrderHandler.GetOrderById(testOrderId);
            testOrderItemId = TestUtil.CreateOrderItemInDB();
            userInfoPage = logInPage.LogInAs(MerchandiserLogin, MerchandiserPassword);
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

            Assert.ReferenceEquals(DBOrderHandler
                .GetOrderByNumber(testOrder.OrderNumber), null);
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderItemHandler.DeleteOrderItemById(testOrderItemId);
            DBOrderHandler.DeleteOrderById(testOrderId);
        }
    }
}
