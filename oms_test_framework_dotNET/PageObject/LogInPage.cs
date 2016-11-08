using System;
using OpenQA.Selenium;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class LogInPage : PageObject
    {
        internal TextInputField usernameInput;
        internal TextInputField passwordInput;
        internal Button logInButton;
        internal Button cancelButton;

        public LogInPage(IWebDriver driver) : base(driver)
        {
            usernameInput = new TextInputField(Driver, new Locator("UserNameInput",
                By.Name("j_username")));

            passwordInput = new TextInputField(Driver, new Locator("PasswordInput",
                By.Name("j_password")));

            logInButton = new Button(Driver, new Locator("LogInButton", By.Name("submit")));

            cancelButton = new Button(Driver, new Locator("CancelButton", By.Name("reset")));
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
            usernameInput.Clear();
            usernameInput.SendKeys(userName);
            return this;
        }

        public LogInPage FillPasswordInput(String password)
        {
            passwordInput.Clear();
            passwordInput.SendKeys(password);
            return this;
        }

        public UserInfoPage ClickLogInButton()
        {
            logInButton.Click();
            return new UserInfoPage(Driver);
        }

        public LogInPage ClickCancelButton()
        {
            cancelButton.Click();
            return this;
        }
    }
}
