using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.PageObject;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {
        //CreateNewOrderLink is unique identifier of CustomerOrderingPage
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/a")]
        public IWebElement CreateNewOrderLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchOrdersDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "searchValue")]
        public IWebElement SearchOrdersInputField { get; set; }

        [FindsBy(How = How.Name, Using = "Apply")]
        public IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='list']//td/a)[1]")]
        public IWebElement FirstBodyEditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']//td[1]")]
        public IWebElement FirstOrderNameCellTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']//td[8]/a")]
        public IWebElement FirstBodyDeleteLink { get; set; }

        public CustomerOrderingPage(IWebDriver driver)
            : base(driver)
        {
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
            return FirstOrderNameCellTextField.Text;
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

