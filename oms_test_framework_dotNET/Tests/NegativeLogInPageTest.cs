using System;
using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class NegativeLogInPageTest : TestRunner
    {
        private const string ValidName = "iva";
        private const string ValidPassword = "qwerty";
        private const string InvalidName = "Neo";
        private const string InvalidPassword = "pizza";
        private const string EmptyField = "";
        [TestMethod]
        public void TestEmptyFieldsLogIn()
        {
            userInfoPage = logInPage.LogInAs(EmptyField, EmptyField);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with empty fields is not successful");
        }
        [TestMethod]
        public void TestEmptyUserNameLogIn()
        {
            userInfoPage = logInPage.LogInAs(EmptyField, ValidPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with empty name is not successful");
        }
        [TestMethod]
        public void TestEmptyPasswordLogIn()
        {
            userInfoPage = logInPage.LogInAs(ValidName, EmptyField);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with empty password is not successful");
        }
        [TestMethod]
        public void TestInvalidLogIn()
        {
            userInfoPage = logInPage.LogInAs(InvalidName, InvalidPassword);
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Text.Equals("User Info"), "Login with invalid credentials is not successful");
        }
    }
}
