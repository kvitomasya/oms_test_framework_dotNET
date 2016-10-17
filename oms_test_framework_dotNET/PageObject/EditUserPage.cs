using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class EditUserPage : PageObject
    {
        // NewPasswordText is unique EditUserPage element
        [FindsBy(How = How.XPath, Using = "//td[contains(., 'New password:')]")]
        public IWebElement NewPasswordText { get; set; }

        public EditUserPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
