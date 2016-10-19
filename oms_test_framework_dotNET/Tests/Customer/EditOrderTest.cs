using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Tests;
using oms_test_framework_dotNET.PageObject;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditOrderTest : TestRunner
    {
        private const String OrderNumber = "100";
        private const String ChangedSearchedOrder = "OrderName100";

        [TestInitialize]
        public void SetUp()
        {
            const String OrderName = "OrderName7";
            const String CustomerLogin = "vpopkin";
            const String CustomerPassword = "qwerty";

            userInfoPage = logInPage.LogInAs(CustomerLogin, CustomerPassword);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();

            customerOrderingPage
                .SelectOrderByName(OrderName)
                .ClickAplyButton()
                .ClickEditLink();

            createNewOrderPage
                .ChangeOrderByNumber(OrderNumber)
                .ClickSaveButton();

            createNewOrderPage
                .ClickCustomerOrderingPageLink();

            customerOrderingPage
               .SelectOrderByName(ChangedSearchedOrder);
        }

        [TestMethod]
        public void TestEditOrder()
        {
            Assert.AreEqual(customerOrderingPage.GetOrderName(), ChangedSearchedOrder, "Order numbers aren't same");
        }

        [TestCleanup]
        public void TearDown()
        {
            customerOrderingPage.ClickEditLink();

            customerOrderingPage
                .ClickEditLink();

            createNewOrderPage
                .ChangeOrderByNumber(OrderNumber)
                .ClickSaveButton();
        }
    }
}