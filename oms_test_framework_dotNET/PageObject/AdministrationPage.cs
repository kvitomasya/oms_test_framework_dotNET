using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace oms_test_framework_dotNET.PageObject
{
    public class AdministrationPage : PageObject
    {
        //FoundUserTextLabel is unique identifier of AdministrationPage
        [FindsBy(How = How.XPath, Using = "//div[@id='list']/h4[1]")]
        public IWebElement FoundUserTextLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }

        public AdministrationPage(IWebDriver driver) : base(driver)
        {
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }
    }
}
