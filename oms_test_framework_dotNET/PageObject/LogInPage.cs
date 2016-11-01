using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class LogInPage : PageObject
    {
        internal TextInputField UsernameInput;
        internal TextInputField PasswordInput;
        internal Button LogInButton;
        internal Button CancelButton;

        public LogInPage(IWebDriver driver) : base(driver)
        {
            UsernameInput = new TextInputField(Driver, new Locator("UserNameInput",
                By.Name("j_username")));

            PasswordInput = new TextInputField(Driver, new Locator("PasswordInput",
                By.Name("j_password")));

            LogInButton = new Button(Driver, new Locator("LogInButton", By.Name("submit")));

            CancelButton = new Button(Driver, new Locator("CancelButton", By.Name("reset")));
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
