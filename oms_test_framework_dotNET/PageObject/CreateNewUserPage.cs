using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateNewUserPage : PageObject
    {
        // PageInfoText is unique CreateNewUserPage element
        [FindsBy(How = How.XPath, Using = "//div[@id='edit']/h3")]
        public IWebElement PageInfoText { get; set; }
        

        public CreateNewUserPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
