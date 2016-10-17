using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorCreateReportPage : PageObject
    {
        // SaveReportLink is unique identifier of AdministratorCreateReportPage
        [FindsBy(How = How.XPath, Using = "//div[@id='list']/a")]
        public IWebElement SaveReportLink { get; set; }


        public AdministratorCreateReportPage(IWebDriver driver) : base(driver)
        {

        }

        public AdministratorReportPage ClickSaveReportLink()
        {
            SaveReportLink.Click();
            return new AdministratorReportPage(Driver);
        }
    }
}
