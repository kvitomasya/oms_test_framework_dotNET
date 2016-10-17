using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorReportPage : PageObject
    {
        // ReportPageExists is unique SupervisorReportPage element
        [FindsBy(How = How.Id, Using = "grid")]
        public IWebElement ReportPageExists { get; set; }

        public SupervisorReportPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
