using System;
using System.Collections.Generic;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    abstract class AbstractElement
    {
        protected IWebDriver Driver;
        protected Locator locator;
        protected By byLocator;

        protected AbstractElement(IWebDriver driver, Locator locator)
        {
            this.Driver = driver;
            this.locator = locator;
            byLocator = locator.GetLocatorValue();
        }

        internal By GetLocatorValue()
        {
            return locator.GetLocatorValue();
        }

        internal string GetLocatorName()
        {
            return locator.GetName();
        }

        public bool IsDisplayed()
        {
            return Driver.FindElement(byLocator).Displayed;
        }

        public bool IsEnabled()
        {
            return Driver.FindElement(byLocator).Enabled;
        }

        public string GetText()
        {
            return Driver.FindElement(byLocator).Text;
        }

        public IWebElement GetElement()
        {
            return Driver.FindElement(byLocator);
        }

        public IReadOnlyCollection<IWebElement> GetElements()
        {
            return Driver.FindElements(byLocator);
        }

        public String GetId()
        {
            return Driver.FindElement(byLocator).GetAttribute("id");
        }

        public String GetNameAttribute()
        {
            return Driver.FindElement(byLocator).GetAttribute("name");
        }

        public String GetValue()
        {
            return Driver.FindElement(byLocator).GetAttribute("value");
        }

        public string GetCssValue(string value)
        {
            return Driver.FindElement(byLocator).GetCssValue(value);
        }

        public String GetType()
        {

            return Driver.FindElement(byLocator).GetAttribute("type");
        }

    }
}
