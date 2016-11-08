using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System.Threading;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

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

            AssertThat(customerOrderingPage.firstOrderNameCellTextField).TextEquals("NewOrderName");

            customerOrderingPage
                .ClickDeleteLink()
                .AcceptAlert();

            Thread.Sleep(1000);

            AssertThat(DBOrderHandler.GetOrderById(testOrderId)).IsNull();
            
        }

        [TestCleanup]
        public void TearDown()
        {
            DBOrderItemHandler.DeleteOrderItemById(testOrderItem);
            DBOrderHandler.DeleteOrderById(testOrderId);
        }
    }
}
