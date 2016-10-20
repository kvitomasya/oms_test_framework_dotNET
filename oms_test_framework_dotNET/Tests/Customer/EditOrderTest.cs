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

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditOrderTest : TestRunner
    {
        private String orderNumber = "10";
        private String changedSearchedOrderName = "OrderName10";
        private String changedSearchedOrderId;

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
                .ChangeOrderByNumber(orderNumber);

            changedSearchedOrderId = createNewOrderPage
                 .OrderNumberField
                 .GetAttribute("Value");

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
            OnTestResult(() =>
            {
                Assert.AreEqual(customerOrderingPage.GetOrderName(), changedSearchedOrderName,
                    "Order numbers should be different");
            });
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderItemHandler.DeleteOrderItemById(int.Parse(changedSearchedOrderId));
        }
    }
}