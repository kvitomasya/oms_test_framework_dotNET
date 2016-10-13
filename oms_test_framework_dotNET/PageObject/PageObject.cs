using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public abstract class PageObject
    {
        [FindsBy(How = How.Id, Using = "logout")]
        public IWebElement LogOutButton { get; set; }

        protected IWebDriver Driver { get; set; }

        public PageObject(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public LogInPage DoLogOut()
        {
            LogOutButton.Click();
            return new LogInPage(Driver);
        }
    }

}
