using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class TextInputField : AbstractClicableElement<TextInputField>
    {
        public TextInputField(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public void Clear()
        {
            Driver.FindElement(byLocator).Clear();
        }

        public void SendKeys(string inputText)
        {
            Driver.FindElement(byLocator).Clear();
            Driver.FindElement(byLocator).SendKeys(inputText);
        }
    }
}
