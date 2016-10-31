using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class TextLabel : AbstractElement
    {
        public TextLabel(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }
    }
}
