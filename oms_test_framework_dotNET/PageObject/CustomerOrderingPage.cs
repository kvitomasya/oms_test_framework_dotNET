using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using System;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {
        internal Link createNewOrderLink;
        internal Link userInfoLink;
        internal DropDown searchOrdersDropdown;
        internal TextInputField searchOrdersInputField;
        internal Button applyButton;
        internal Link firstBodyEditLink;
        internal Element firstOrderNameCellTextField;
        internal Link firstBodyDeleteLink;

        public CustomerOrderingPage(IWebDriver driver)
            : base(driver)
        {
            //CreateNewOrderLink is unique identifier of CustomerOrderingPage
            createNewOrderLink = new Link(Driver, new Locator("CreateNewOrderLink",
                By.XPath("//div[@id='content']/a")));

            userInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            searchOrdersDropdown = new DropDown(Driver, new Locator("SearchOrdersDropdown",
                By.Id("search")));

            searchOrdersInputField = new TextInputField(Driver, new Locator("SearchOrdersInputField",
                By.Id("searchValue")));

            applyButton = new Button(Driver, new Locator("ApplyButton", By.Name("Apply")));

            firstBodyEditLink = new Link(Driver, new Locator("FirstBodyEditLink",
                By.XPath("(//div[@id='list']//td/a)[1]")));

            firstOrderNameCellTextField = new Element(Driver, new Locator("FirstOrderNameCellTextField",
                By.XPath("//div[@id='list']//td[1]")));

            firstBodyDeleteLink = new Link(Driver, new Locator("FirstBodyDeleteLink",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[8]")));
        }

        public UserInfoPage ClickUserInfoLink()
        {
            userInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public CustomerOrderingPage SelectOrderByName(String orderName)
        {
            searchOrdersInputField.Clear();
            searchOrdersInputField.SendKeys(orderName);
            return this;
        }

        public CustomerOrderingPage ClickAplyButton()
        {
            applyButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickEditLink()
        {
            firstBodyEditLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public String GetOrderName()
        {
            return firstOrderNameCellTextField.GetText();
        }

        public CreateNewOrderPage ClickCreateNewOrderLink()
        {
            createNewOrderLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public CustomerOrderingPage ClickDeleteLink()
        {
            firstBodyDeleteLink.Click();
            return new CustomerOrderingPage(Driver);
        }
    }
}

