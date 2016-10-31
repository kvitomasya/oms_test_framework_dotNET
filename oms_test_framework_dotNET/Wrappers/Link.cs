using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class Link : AbstractClicableElement<Link>
    {
        public Link(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }
    }
}
