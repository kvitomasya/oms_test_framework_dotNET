using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserEditOrderPage : PageObject
    {
        internal CheckBox IsGiftCheckbox;
        public MerchandiserEditOrderPage(IWebDriver driver) : base(driver)
        {
            // IsGiftCheckbox is unique identifier of MerchandiserEditOrderPage
            IsGiftCheckbox = new CheckBox(Driver, new Locator("IsGiftCheckbox",
                By.XPath("//input[@type='checkbox']")));
        }
    }
}
