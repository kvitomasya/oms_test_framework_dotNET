using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorReportPage : PageObject
    {
        internal TextLabel reportPageExists;

        public SupervisorReportPage(IWebDriver driver) : base(driver)
        {
            // ReportPageExists is unique identifier of SupervisorReportPage
            reportPageExists = new TextLabel(Driver, new Locator("ReportPageExists", By.Id("grid")));
        }
    }
}
