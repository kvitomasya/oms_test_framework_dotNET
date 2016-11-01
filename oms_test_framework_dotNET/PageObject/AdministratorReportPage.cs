using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorReportPage : PageObject
    {
        internal TextLabel ReportPageExists;
        public AdministratorReportPage(IWebDriver driver) : base(driver)
        {
            // ReportPageExists is unique identifier of AdministratorReportPage
            ReportPageExists = new TextLabel(Driver, new Locator("ReportPageExists", By.Id("grid")));
        }
    }
}
