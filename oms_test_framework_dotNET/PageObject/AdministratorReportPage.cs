using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorReportPage : PageObject
    {
        // ReportPageExists is unique identifier of AdministratorReportPage
        [FindsBy(How = How.Id, Using = "grid")]
        public IWebElement ReportPageExists { get; set; }

        public AdministratorReportPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
