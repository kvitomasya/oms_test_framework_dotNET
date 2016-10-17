using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministratorReportPage : PageObject
    {
        // ReportPageExists is unique AdministratorReportPage element
        [FindsBy(How = How.Id, Using = "grid")]
        public IWebElement ReportPageExists { get; set; }

        public AdministratorReportPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
