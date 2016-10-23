using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorReportPage : PageObject
    {
        // ReportPageExists is unique identifier of SupervisorReportPage
        [FindsBy(How = How.Id, Using = "grid")]
        public IWebElement ReportPageExists { get; set; }

        public SupervisorReportPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
