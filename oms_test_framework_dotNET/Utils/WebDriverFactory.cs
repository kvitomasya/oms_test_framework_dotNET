using oms_test_framework_dotNET.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Utils
{
    public class WebDriverFactory
    {
        private IWebDriver Driver { get; set; }

        public IWebDriver GetDriver(Browsers browser)
        {
            switch(browser)
            {
                case Browsers.FIREFOX:
                    Driver = new FirefoxDriver();
                    break;

                case Browsers.CHROME:
                    Driver = new ChromeDriver(@"..\\..\\Resources\Drivers");
                    break;

                case Browsers.EXPLORER:
                    Driver = new InternetExplorerDriver(@"..\\..\\Resources\Drivers");
                    break;

                default:
                    throw new ArgumentException("Browser name is not valid !");
            }
            return Driver;
        }
    }
}
