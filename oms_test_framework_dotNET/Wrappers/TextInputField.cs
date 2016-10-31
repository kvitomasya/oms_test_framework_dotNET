using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class TextInputField : AbstractClicableElement<TextInputField>
    {
        public TextInputField(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public void clear()
        {
            Driver.FindElement(ByLocator).Clear();
        }

        public void sendKeys(string inputText)
        {
            Driver.FindElement(ByLocator).Clear();
            Driver.FindElement(ByLocator).SendKeys(inputText);
        }
    }
}
