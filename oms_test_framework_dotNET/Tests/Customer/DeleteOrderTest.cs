using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Tests;
using oms_test_framework_dotNET.PageObject;
using oms_test_framework_dotNET.DBHelpers;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class DeleteOrderTest : TestRunner
    {
        private int testOrderId;
        private int testOrderItem;

        [ClassInitialize]
        public void CreateOrder()
        {
            testOrderId = DBHelper.createValidOrderInDB();
            testOrderItem = DBHelper.createOrderItemInDB();
        }

        [TestInitialize]
        public void SetUp()
        {
            const String CustomerLogin = "vpopkin";
            const String CustomerPassword = "qwerty";

            userInfoPage = logInPage.LogInAs(CustomerLogin, CustomerPassword);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void TestDeleteOrder()
        {
            customerOrderingPage
               .SelectOrderByName("OrderName" + testOrderId)
               .ClickAplyButton()
               .ClickDeleteLink();

            Driver.SwitchTo().Alert().Dismiss();

            Assert.AreEqual(customerOrderingPage
                .GetOrderName(), "OrderName" + testOrderId,
                "Order name should be equals");

            customerOrderingPage
                .ClickDeleteLink();

            Driver.SwitchTo().Alert().Accept();

            Assert.IsTrue(customerOrderingPage
                .FirstOrderNameCellTextField
                .Displayed, "Order name should be displyed");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderHandler.DeleteOrderById(testOrderId);
            DBOrderHandler.DeleteOrderById(testOrderItem);
        }
    }
}
