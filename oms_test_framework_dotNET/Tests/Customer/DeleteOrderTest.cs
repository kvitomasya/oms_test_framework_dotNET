using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System.Threading;

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
            testOrderId = TestHelper.CreateValidOrderInDB();
            testOrderItem = TestHelper.CreateOrderItemInDB();

            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void TestDeleteOrder()
        {
            customerOrderingPage
               .SelectOrderByName("NewOrderName")
               .ClickAplyButton()
               .ClickDeleteLink()
               .DismissAlert();

            Assert.AreEqual(customerOrderingPage
                .GetOrderName(), "NewOrderName",
                "Order name should be equals");

            customerOrderingPage
                .ClickDeleteLink()
                .AcceptAlert();

            Thread.Sleep(1000);

            Assert.IsTrue(DBOrderHandler.GetOrderById(testOrderId) == null,
                "Deleted order still exists !");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderItemHandler.DeleteOrderItemById(testOrderItem);
            DBOrderHandler.DeleteOrderById(testOrderId);
        }
    }
}
