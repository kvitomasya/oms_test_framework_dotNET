using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

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
            AssertThat(customerOrderingPage.createNewOrderLink).IsDisplayed();
                
            customerOrderingPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestCreateNewOrderPageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();

            AssertThat(createNewOrderPage.cVV2Text).IsDisplayed();

            createNewOrderPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestAddItemPageLogOutAbility()
        {
            createNewOrderPage = customerOrderingPage.ClickCreateNewOrderLink();
            addItemPage = createNewOrderPage.ClickAddItemButton();

            AssertThat(addItemPage.resetButton).IsDisplayed();

            addItemPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
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
                .orderNumberField
                .Clear();
            orderItemsErrorMessagePage = createNewOrderPage
                            .ClickPreferableDeliveryDateChooseLink()
                            .ClickCalendarMonthForwardButton()
                            .ClickDateLink()
                            .SelectAssigneeDropdown("login1")
                            .ClickSaveButtonFail();

            AssertThat(orderItemsErrorMessagePage.orderItemsErrorMessageText).IsDisplayed();

            orderItemsErrorMessagePage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }
    }
}
