using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class Button : AbstractClicableElement<Button>
    {
        public Button(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public void Submit()
        {
            Driver.FindElement(ByLocator).Submit();
        }

    }

}
