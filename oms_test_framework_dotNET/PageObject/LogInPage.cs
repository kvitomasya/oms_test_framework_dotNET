using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;

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

        public UserInfoPage LogInAs(Roles role)
        {
            const String InvalidUserLogin = "Saruman";
            const String InvalidUserPassword = "mordor";

            if (role == Roles.INVALID_USER)
            {
                LogInAs(InvalidUserLogin, InvalidUserPassword);
            }
            else
            {
                User user = DBUserHandler.GetUserByRole(role);
                LogInAs(user.Login, user.Password);
            }
            return new UserInfoPage(Driver);
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
