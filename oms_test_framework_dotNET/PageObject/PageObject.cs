using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public abstract class PageObject
    {
        internal Button LogOutButton;
        protected IWebDriver Driver { get; set; }

        public PageObject(IWebDriver driver)
        {
            this.Driver = driver;
            LogOutButton = new Button(Driver, new Locator("LogOutButton", By.Id("logout")));
        }

        public LogInPage DoLogOut()
        {
            LogOutButton.Click();
            AcceptAlert();
            return new LogInPage(Driver);
        }

        public void AcceptAlert()
        {
            Driver
                .SwitchTo()
                .Alert()
                .Accept();
        }

        public void DismissAlert()
        {
            Driver
                .SwitchTo()
                .Alert()
                .Dismiss();
        }
    }
}
