using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    abstract class AbstractElement
    {
        protected IWebDriver Driver;
        protected Locator Locator;
        protected By ByLocator;

        protected AbstractElement(IWebDriver driver, Locator locator)
        {
            this.Driver = driver;
            this.Locator = locator;
            ByLocator = Locator.locator;
        }

        public bool IsDisplayed()
        {
            return Driver.FindElement(ByLocator).Displayed;
        }

        public bool IsEnabled()
        {
            return Driver.FindElement(ByLocator).Enabled;
        }

        public string GetText()
        {
            return Driver.FindElement(ByLocator).Text;
        }

        public IReadOnlyCollection<IWebElement> GetElements()
        {
            return Driver.FindElements(ByLocator);
        }

        public String GetId()
        {
            return Driver.FindElement(ByLocator).GetAttribute("id");
        }

        public String GetNameAttribute()
        {
            return Driver.FindElement(ByLocator).GetAttribute("name");
        }

        public String GetValue()
        {
            return Driver.FindElement(ByLocator).GetAttribute("value");
        }

        public string GetCssValue(string value)
        {
            return Driver.FindElement(ByLocator).GetCssValue(value);
        }

        public String GetType()
        {

            return Driver.FindElement(ByLocator).GetAttribute("type");
        }

    }
}
