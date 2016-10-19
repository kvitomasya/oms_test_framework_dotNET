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
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class DeleteOrderTest : TestRunner
    {
        private int testOrderId;
        private int testOrderItem;

        [TestInitialize]
        public void SetUp()
        {
            testOrderId = DBHelper.createValidOrderInDB();
            testOrderItem = DBHelper.createOrderItemInDB();

            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void TestDeleteOrder()
        {
            customerOrderingPage
               .SelectOrderByName("TestOrder")
               .ClickAplyButton()
               .ClickDeleteLink();

            Driver.SwitchTo().Alert().Dismiss();

            Assert.AreEqual(customerOrderingPage
                .GetOrderName(), "TestOrder",
                "Order name should be equals");

            customerOrderingPage
                .ClickDeleteLink();

            Driver.SwitchTo().Alert().Accept();

            Assert.IsTrue(DBOrderHandler.GetOrderById(testOrderId) == null,
                "Deleted order still exists !");
        }
    }
}
