using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorCreateReportPage : PageObject
    {
        internal Link SaveReportLink;

        public AdministratorCreateReportPage(IWebDriver driver) : base(driver)
        {
            // SaveReportLink is unique identifier of AdministratorCreateReportPage
            SaveReportLink = new Link(Driver, new Locator("SaveReportLink",
                By.XPath("//div[@id='list']/a")));
        }

        public AdministratorReportPage ClickSaveReportLink()
        {
            SaveReportLink.Click();
            return new AdministratorReportPage(Driver);
        }
    }
}
