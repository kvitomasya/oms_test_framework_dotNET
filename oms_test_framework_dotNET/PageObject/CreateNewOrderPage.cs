using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateNewOrderPage : PageObject
    {
        internal TextLabel CVV2Text;
        internal Button AddItemButton;
        internal TextInputField OrderNumberField;
        internal Link PreferableDeliveryDateChooseLink;
        internal Element CalendarPopupElement;
        internal Button CalendarMonthForwardButton;
        internal Link DateLink;
        internal DropDown AssigneeDropdown;
        internal Button SaveButton;
        internal Link CustomerOrderingPageLink;

        public CreateNewOrderPage(IWebDriver driver)
           : base(driver)
        {
            // CVV2Text is unique identifier of CreateNewOrderPage
            CVV2Text = new TextLabel(Driver, new Locator("CVV2Text",
                By.XPath("//form[@id='form2']//tr[3]/td[1]/strong")));

            AddItemButton = new Button(Driver, new Locator("AddItemButton",
                By.XPath("//form[@id='addItem']/input[@value = 'Add Item']")));

            OrderNumberField = new TextInputField(Driver, new Locator("OrderNumberField",
                By.Id("orderNum")));

            PreferableDeliveryDateChooseLink = new Link(Driver,
                new Locator("PreferableDeliveryDateChooseLink", By.ClassName("dp-choose-date")));

            CalendarPopupElement = new Element(Driver, new Locator("CalendarPopupElement",
                By.XPath("//div[@id='dp-popup']")));

            CalendarMonthForwardButton = new Button(Driver, new Locator("CalendarMonthForwardButton",
                By.XPath("//div[@id='dp-popup']/div[2]/a[2]")));

            DateLink = new Link(Driver, new Locator("DateLink",
                By.XPath("//div[@id='dp-popup']//tbody/tr[3]/td[4]")));

            AssigneeDropdown = new DropDown(Driver, new Locator("AssigneeDropdown",
                By.Id("assignee")));

            SaveButton = new Button(Driver, new Locator("SaveButton", By.Id("save")));

            CustomerOrderingPageLink = new Link(Driver, new Locator("ClickCustomerOrderingPageLink",
                 By.XPath("(//ul[@id='nav']//a)[1]")));
        }

        public AddItemPage ClickAddItemButton()
        {
            AddItemButton.Submit();
            return new AddItemPage(Driver);
        }

        public CreateNewOrderPage ClickPreferableDeliveryDateChooseLink()
        {
            PreferableDeliveryDateChooseLink.Click();
            return this;
        }

        public CreateNewOrderPage ClickCalendarMonthForwardButton()
        {
            CalendarMonthForwardButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickDateLink()
        {
            DateLink.Click();
            return this;
        }

        public CreateNewOrderPage SelectAssigneeDropdown(String AssigneeLogin)
        {
            AssigneeDropdown.SendKeys(AssigneeLogin);
            return this;
        }

        public OrderItemsErrorMessagePage ClickSaveButtonFail()
        {
            SaveButton.Click();
            return new OrderItemsErrorMessagePage(Driver);
        }

        public CreateNewOrderPage ChangeOrderByNumber(String orderNumber)
        {
            OrderNumberField.Clear();
            OrderNumberField.SendKeys(orderNumber);
            return this;
        }

        public CreateNewOrderPage ClickSaveButton()
        {
            SaveButton.Click();
            return this;
        }

        public String GetChangedOrderNumber()
        {
            return OrderNumberField
                .GetValue();
        }

        public CustomerOrderingPage ClickCustomerOrderingPageLink()
        {
            CustomerOrderingPageLink.Click();
            return new CustomerOrderingPage(Driver);
        }
    }
}
