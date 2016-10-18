using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Customer
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.CUSTOMER);
            customerOrderingPage = userInfoPage.ClickCustomerOrderingLink();
        }

        [TestMethod]
        public void TestCustomerOrderingPageLogOutAbility()
        {
            Assert.IsTrue(customerOrderingPage.CreateNewOrderLink.Displayed,
                "Customer Ordering page doesn't exist");
            customerOrderingPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestCreateNewOrderPageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();
            Assert.IsTrue(createNewOrderPage.CVV2Text.Displayed,
                "Create new order page doesn't exists");
            createNewOrderPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestAddItemPageLogOutAbility()
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
        public void TestOrderItemsErrorMessagePageLogOutAbility()
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
