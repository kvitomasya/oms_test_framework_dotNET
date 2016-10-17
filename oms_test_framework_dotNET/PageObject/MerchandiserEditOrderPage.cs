using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserEditOrderPage : PageObject
    {
        // IsGiftCheckbox is unique identifier of MerchandiserEditOrderPage
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        public IWebElement IsGiftCheckbox { get; set; }

        public MerchandiserEditOrderPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
