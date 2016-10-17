using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class LogOutTest : TestRunner
    {
        private const String CustomerLogin = "vpopkin";
        private const String CustomerPassword = "qwerty";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(CustomerLogin, CustomerPassword);
            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void testCustomerOrderingPageLogOutAbility()
        {
            Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed,
                "Customer Ordering page doesn't exist");
            customerOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testCreateNewOrderPageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();
            Assert.IsTrue(createNewOrderPage.CVV2Text.Displayed,
                "Create new order page doesn't exists");
            createNewOrderPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testAddItemPageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();
            addItemPage = createNewOrderPage.ClickAddItemButton();
            Assert.IsTrue(addItemPage.ResetButton.Displayed,
                "Add item page doesn't exists");
            addItemPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void testOrderItemsErrorMessagePageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();
            addItemPage = createNewOrderPage.ClickAddItemButton();
            addItemPage
                .ClickSelectFirstItemLink()
                .ClickDoneButton();
            createNewOrderPage
                .OrderNumberField
                .Clear();
            orderItemsErrorMessagePage = createNewOrderPage
                            .ClickPreferableDeliveryDateChooseLink()
                            .ClickCalendarMonthForwardButton()
                            .ClickDateLink()
                            .SelectAssigneeDropdown("login1")
                            .ClickSaveButtonFail();
            Assert.IsTrue(orderItemsErrorMessagePage.OrderItemsErrorMessageText.Displayed,
                "Order items error message page doesn't exists");
            orderItemsErrorMessagePage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
