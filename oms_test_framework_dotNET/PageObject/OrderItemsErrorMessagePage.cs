using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class OrderItemsErrorMessagePage : PageObject
    {
        // OrderItemsErrorMessageText is unique OrderItemsErrorMessagePage element
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/ancestor::div[@id='site_content']")]
        public IWebElement OrderItemsErrorMessageText { get; set; }

        public OrderItemsErrorMessagePage(IWebDriver driver) : base(driver)
        {

        }
    }
}
