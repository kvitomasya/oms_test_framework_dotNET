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
        //SearchByText is unique identifier of MerchandiserOrderingPage
        [FindsBy(How = How.XPath, Using = "//form[@id='searchFilter']//tr/td[1]")]
        public IWebElement SearchByText { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }

        public MerchandiserOrderingPage(IWebDriver driver) : base(driver)
        {
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }
    }
}
