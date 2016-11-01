using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorCreateReportPage : PageObject
    {
        internal Link SaveReportLink;

        public SupervisorCreateReportPage(IWebDriver driver) : base(driver)
        {
            // SaveReportLink is unique identifier of SupervisorCreateReportPage
            SaveReportLink = new Link(Driver, new Locator("SaveReportLink",
                By.XPath("//div[@id='list']/a")));
        }

        public SupervisorReportPage ClickSaveReportLink()
        {
            SaveReportLink.Click();
            return new SupervisorReportPage(Driver);
        }
    }
}
