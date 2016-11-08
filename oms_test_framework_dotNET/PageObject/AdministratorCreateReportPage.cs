using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorCreateReportPage : PageObject
    {
        internal Link saveReportLink;

        public AdministratorCreateReportPage(IWebDriver driver) : base(driver)
        {
            // SaveReportLink is unique identifier of AdministratorCreateReportPage
            saveReportLink = new Link(Driver, new Locator("SaveReportLink",
                By.XPath("//div[@id='list']/a")));
        }

        public AdministratorReportPage ClickSaveReportLink()
        {
            saveReportLink.Click();
            return new AdministratorReportPage(Driver);
        }
    }
}
