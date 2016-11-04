using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class OrderItemsErrorMessagePage : PageObject
    {
        internal Element orderItemsErrorMessageText;

        public OrderItemsErrorMessagePage(IWebDriver driver) : base(driver)
        {
            // OrderItemsErrorMessageText is unique identifier of OrderItemsErrorMessagePage
            orderItemsErrorMessageText = new Element(Driver, new Locator("OrderItemsErrorMessageText",
                By.XPath("//div[@id='content']/ancestor::div[@id='site_content']")));
        }
    }
}
