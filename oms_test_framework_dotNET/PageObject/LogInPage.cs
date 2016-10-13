using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class LogInPage : PageObject
    {
        [FindsBy(How = How.Name, Using = "j_username")]
        public IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Name, Using = "j_password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement LogInButton { get; set; }

        [FindsBy(How = How.Name, Using = "reset")]
        public IWebElement CancelButton { get; set; }

        public LogInPage(IWebDriver driver) : base(driver)
        {
        }

        public UserInfoPage LogInAs(String username, String password)
        {
            return FillUsernameInput(username)
                .FillPasswordInput(password)
                .ClickLogInButton();

        }

        public LogInPage FillUsernameInput(String userName)
        {
            UsernameInput.Clear();
            UsernameInput.SendKeys(userName);
            return this;
        }

        public LogInPage FillPasswordInput(String password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
            return this;
        }

        public UserInfoPage ClickLogInButton()
        {
            LogInButton.Click();
            return new UserInfoPage(Driver);
        }

        public LogInPage ClickCancelButton()
        {
            CancelButton.Click();
            return this;
        }
    }

}
