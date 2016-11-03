using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {
        internal Link CreateNewOrderLink;
        internal Link UserInfoLink;
        internal DropDown SearchOrdersDropdown;
        internal TextInputField SearchOrdersInputField;
        internal Button ApplyButton;
        internal Link FirstBodyEditLink;
        internal Element FirstOrderNameCellTextField;
        internal Link FirstBodyDeleteLink;

        public CustomerOrderingPage(IWebDriver driver)
            : base(driver)
        {
            //CreateNewOrderLink is unique identifier of CustomerOrderingPage
            CreateNewOrderLink = new Link(Driver, new Locator("CreateNewOrderLink",
                By.XPath("//div[@id='content']/a")));

            UserInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            SearchOrdersDropdown = new DropDown(Driver, new Locator("SearchOrdersDropdown",
                By.Id("search")));

            SearchOrdersInputField = new TextInputField(Driver, new Locator("SearchOrdersInputField",
                By.Id("searchValue")));

            ApplyButton = new Button(Driver, new Locator("ApplyButton", By.Name("Apply")));

            FirstBodyEditLink = new Link(Driver, new Locator("FirstBodyEditLink",
                By.XPath("(//div[@id='list']//td/a)[1]")));

            FirstOrderNameCellTextField = new Element(Driver, new Locator("FirstOrderNameCellTextField",
                By.XPath("//div[@id='list']//td[1]")));

            FirstBodyDeleteLink = new Link(Driver, new Locator("FirstBodyDeleteLink",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[8]")));
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public CustomerOrderingPage SelectOrderByName(String orderName)
        {
            SearchOrdersInputField.Clear();
            SearchOrdersInputField.SendKeys(orderName);
            return this;
        }

        public CustomerOrderingPage ClickAplyButton()
        {
            ApplyButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickEditLink()
        {
            FirstBodyEditLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public String GetOrderName()
        {
            return FirstOrderNameCellTextField.GetText();
        }

        public CreateNewOrderPage ClickCreateNewOrderLink()
        {
            CreateNewOrderLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public CustomerOrderingPage ClickDeleteLink()
        {
            FirstBodyDeleteLink.Click();
            return new CustomerOrderingPage(Driver);
        }
    }
}

