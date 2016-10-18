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
        // ConfirmPasswordText is unique identifier of EditUserPage
        [FindsBy(How = How.Id, Using = "confirmPassword")]
        public IWebElement ConfirmPasswordText { get; set; }

        public EditUserPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
