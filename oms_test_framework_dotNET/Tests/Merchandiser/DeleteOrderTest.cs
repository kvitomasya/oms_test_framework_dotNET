using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System.Threading;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

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

            AssertThat(merchandiserOrderingPage.firstOrderNameCell).TextEquals(testOrder.OrderName);

            AssertThat(merchandiserOrderingPage.firstOrderDeleteCell).IsDisplayed();
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

            AssertThat(DBOrderHandler
                .GetOrderByNumber(testOrder.OrderNumber)).AreEquals(testOrder);
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

            AssertThat(DBOrderHandler.GetOrderByNumber(testOrder.OrderNumber)).IsNull();
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderItemHandler.DeleteOrderItemById(testOrderItemId);
        }
    }
}
