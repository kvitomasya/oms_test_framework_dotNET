using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditOrderTest : TestRunner
    {
        private String orderNumber = "10";
        private String changedSearchedOrderName = "OrderName10";

        private int testOrderId;
        private int testOrderItem;

        [TestInitialize]
        public void SetUp()
        {
            testOrderId = TestHelper.CreateValidOrderInDB();
            testOrderItem = TestHelper.CreateOrderItemInDB();

            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();

            createNewOrderPage = customerOrderingPage
                .SelectOrderByName("NewOrderName")
                .ClickAplyButton()
                .ClickEditLink();

            createNewOrderPage
                .ChangeOrderByNumber(orderNumber);

            createNewOrderPage
                .ClickSaveButton();

            createNewOrderPage
                .ClickCustomerOrderingPageLink();

            customerOrderingPage
                .SelectOrderByName(changedSearchedOrderName)
                .ClickAplyButton();
        }

        [TestMethod]
        public void TestEditOrder()
        {

            Assert.AreEqual(customerOrderingPage.GetOrderName(), changedSearchedOrderName,
                "Order numbers should be different");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderItemHandler.DeleteOrderItemById(testOrderItem);
        }
    }
}