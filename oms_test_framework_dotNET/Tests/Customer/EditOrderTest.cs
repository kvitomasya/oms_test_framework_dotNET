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

        private const String CustomerLogin = "vpopkin";
        private const String CustomerPassword = "qwerty";
        private const String SearchedOrder = "OrderName6";
        private const String OrderNumber = "7";
        private const String ChengedSearchedOrder = "OrderName7";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(CustomerLogin, CustomerPassword);

            customerOrderingPage = userInfoPage.ClickCustomerOrderingPageLink();

            customerOrderingPage
                .SelectOrderByName(SearchedOrder)
                .ClickAplyButton()
                .ClickEditLink();

            createNewOrderPage
                .ChangeOrderByName(OrderNumber)
                .ClickSaveButton();

            createNewOrderPage
                .ClickCustomerOrderingPageLink();

            customerOrderingPage
               .SelectOrderByName(ChengedSearchedOrder);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(customerOrderingPage.GetOrderName(), ChengedSearchedOrder, "Order numbers aren't same");
        }

        [TestCleanup]
        public void TearDown()
        {
            customerOrderingPage.ClickEditLink();

            customerOrderingPage
                .ClickEditLink();

            createNewOrderPage
                .ChangeOrderByName(OrderNumber)
                .ClickSaveButton();
        }

    }
}