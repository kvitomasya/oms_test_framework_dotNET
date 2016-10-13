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
        // pageInfoText is unique CreateNewUserPage element

        public CreateNewUserPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
