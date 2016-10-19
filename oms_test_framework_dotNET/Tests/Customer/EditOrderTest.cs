using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Tests;
using oms_test_framework_dotNET.PageObject;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.DBHelpers;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditOrderTest : TestRunner
    {
        private String orderNumber = "10";
        private String changedSearchedOrder;

        private int testOrderId;
        private int testOrderItem;

        [TestInitialize]
        public void SetUp()
        {
            testOrderId = DBHelper.createValidOrderInDB();
            testOrderItem = DBHelper.createOrderItemInDB();

            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();

            createNewOrderPage = customerOrderingPage
                .SelectOrderByName("TestOrder")
                .ClickAplyButton()
                .ClickEditLink();

            createNewOrderPage
                .OrderNumberField
                .Clear();

            createNewOrderPage
                .OrderNumberField
                .SendKeys(orderNumber);

            changedSearchedOrder = createNewOrderPage
                 .OrderNumberField
                 .GetAttribute("Value");

            createNewOrderPage
                .ClickSaveButton();

            createNewOrderPage
                .ClickCustomerOrderingPageLink();

            customerOrderingPage
                .SearchOrdersInputField
                .Clear();

            customerOrderingPage
                .SelectOrderByName("OrderName10")
                .ClickAplyButton();
        }

        [TestMethod]
        public void TestEditOrder()
        {
            

            Assert.AreEqual(customerOrderingPage.GetOrderName(), "OrderName10",
                "Order numbers should be different");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderItemHandler.DeleteOrderItemById(int.Parse(changedSearchedOrder));
        }
    }
}