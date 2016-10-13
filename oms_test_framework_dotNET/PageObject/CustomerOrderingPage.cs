using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {
        // CreateNewOrderLink is an unique CustomerOrderingPage element
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/a")]
        public IWebElement CreateNewOrderLink { get; set; }

        public CustomerOrderingPage(IWebDriver driver) : base(driver)
        {

        }

        public CreateNewOrderPage ClickCreateNewOrderLink()
        {
            CreateNewOrderLink.Click();
            return new CreateNewOrderPage(Driver);
        }
    }
}
