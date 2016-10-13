using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserOrderingPage : PageObject
    {
        // SearchByTextLabel is unique MerchandiserOrderingPage element
        [FindsBy(How = How.XPath, Using = "//form[@id='searchFilter']//tr/td[1]")]
        public IWebElement SearchByTextLabel { get; set; }

        public MerchandiserOrderingPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
