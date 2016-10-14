using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchOrdersDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "searchValue")]
        public IWebElement SearchOrdersInputField { get; set; }

        [FindsBy(How = How.Name, Using = "Apply")]
        public IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='list']//td/a)[1]")]
        public IWebElement FirstTBodyEditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']//td[1]")]
        public IWebElement FirstTBodyOrderNameTextLable { get; set; }

        public CustomerOrderingPage(IWebDriver driver) : base(driver)
        {
        }

        public CustomerOrderingPage SelectOrderByName(String searchedOrder)
        {
            SearchOrdersInputField.Clear();
            SearchOrdersInputField.SendKeys(searchedOrder);
            return this;
        }

        public CustomerOrderingPage ClickAplyButton()
        {
            ApplyButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickEditLink()
        {
            FirstTBodyEditLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public String GetOrderName()
        {
            return FirstTBodyOrderNameTextLable.Text;
        }

    }
}