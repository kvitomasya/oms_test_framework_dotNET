using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateNewOrderPage : PageObject
    {
        internal TextLabel cVV2Text;
        internal Button addItemButton;
        internal TextInputField orderNumberField;
        internal Link preferableDeliveryDateChooseLink;
        internal Element calendarPopupElement;
        internal Button calendarMonthForwardButton;
        internal Link dateLink;
        internal DropDown assigneeDropdown;
        internal Button saveButton;
        internal Link customerOrderingPageLink;

        public CreateNewOrderPage(IWebDriver driver)
           : base(driver)
        {
            // CVV2Text is unique identifier of CreateNewOrderPage
            cVV2Text = new TextLabel(Driver, new Locator("CVV2Text",
                By.XPath("//form[@id='form2']//tr[3]/td[1]/strong")));

            addItemButton = new Button(Driver, new Locator("AddItemButton",
                By.XPath("//form[@id='addItem']/input[@value = 'Add Item']")));

            orderNumberField = new TextInputField(Driver, new Locator("OrderNumberField",
                By.Id("orderNum")));

            preferableDeliveryDateChooseLink = new Link(Driver,
                new Locator("PreferableDeliveryDateChooseLink", By.ClassName("dp-choose-date")));

            calendarPopupElement = new Element(Driver, new Locator("CalendarPopupElement",
                By.XPath("//div[@id='dp-popup']")));

            calendarMonthForwardButton = new Button(Driver, new Locator("CalendarMonthForwardButton",
                By.XPath("//div[@id='dp-popup']/div[2]/a[2]")));

            dateLink = new Link(Driver, new Locator("DateLink",
                By.XPath("//div[@id='dp-popup']//tbody/tr[3]/td[4]")));

            assigneeDropdown = new DropDown(Driver, new Locator("AssigneeDropdown",
                By.Id("assignee")));

            saveButton = new Button(Driver, new Locator("SaveButton", By.Id("save")));

            customerOrderingPageLink = new Link(Driver, new Locator("ClickCustomerOrderingPageLink",
                 By.XPath("(//ul[@id='nav']//a)[1]")));
        }

        public AddItemPage ClickAddItemButton()
        {
            addItemButton.Submit();
            return new AddItemPage(Driver);
        }

        public CreateNewOrderPage ClickPreferableDeliveryDateChooseLink()
        {
            preferableDeliveryDateChooseLink.Click();
            return this;
        }

        public CreateNewOrderPage ClickCalendarMonthForwardButton()
        {
            calendarMonthForwardButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickDateLink()
        {
            dateLink.Click();
            return this;
        }

        public CreateNewOrderPage SelectAssigneeDropdown(String AssigneeLogin)
        {
            assigneeDropdown.SendKeys(AssigneeLogin);
            return this;
        }

        public OrderItemsErrorMessagePage ClickSaveButtonFail()
        {
            saveButton.Click();
            return new OrderItemsErrorMessagePage(Driver);
        }

        public CreateNewOrderPage ChangeOrderByNumber(String orderNumber)
        {
            orderNumberField.Clear();
            orderNumberField.SendKeys(orderNumber);
            return this;
        }

        public CreateNewOrderPage ClickSaveButton()
        {
            saveButton.Click();
            return this;
        }

        public String GetChangedOrderNumber()
        {
            return orderNumberField
                .GetValue();
        }

        public CustomerOrderingPage ClickCustomerOrderingPageLink()
        {
            customerOrderingPageLink.Click();
            return new CustomerOrderingPage(Driver);
        }
    }
}
