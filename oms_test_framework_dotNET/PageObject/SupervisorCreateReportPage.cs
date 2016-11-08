using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorCreateReportPage : PageObject
    {
        internal Link saveReportLink;

        public SupervisorCreateReportPage(IWebDriver driver) : base(driver)
        {
            // SaveReportLink is unique identifier of SupervisorCreateReportPage
            saveReportLink = new Link(Driver, new Locator("SaveReportLink",
                By.XPath("//div[@id='list']/a")));
        }

        public SupervisorReportPage ClickSaveReportLink()
        {
            saveReportLink.Click();
            return new SupervisorReportPage(Driver);
        }
    }
}
