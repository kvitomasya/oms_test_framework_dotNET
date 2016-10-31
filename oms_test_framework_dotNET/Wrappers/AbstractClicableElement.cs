using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    abstract class AbstractClicableElement<T> : AbstractElement
    {
        public AbstractClicableElement(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public T Click()
        {
            Driver.FindElement(ByLocator).Click();
            return (T)Convert.ChangeType(this, typeof(T));
        }
    }

}

