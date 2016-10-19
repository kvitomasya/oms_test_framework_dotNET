using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;

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
            //testOrder = DBOrderHandler.GetOrderById(testOrderId);
            //testOrderItemId = TestUtil.CreateOrderItemInDB();
            userInfoPage = logInPage.LogInAs(MerchandiserLogin, MerchandiserPassword);
            merchandiserOrderingPage = userInfoPage.ClickMerchandiserOrderingLink();
        }

        [TestMethod]
        public void TestOrdersElementsPresence()
        {

            //merchandiserOrderingPage.SelectSearchDropdown("Order Name")
            //   .FillSearchInput(testOrder.OrderName)
            //   .ClickApplyButton();

            //Assert.IsTrue(merchandiserOrderingPage.FirstOrderNameCell.Text.Equals(testOrder.OrderName));

            //assertThat(merchandiserOrderingPage.getDeleteCellLink())
            //        .isDisplayed();

        }

        [TestCleanup]
        public void TearDown()
        {
            //DBOrderHandler.DeleteOrderById(testOrderId);
            //DBOrderItemHandler.DeleteOrderItemById(testOrderItemId);
        }
    }
}
