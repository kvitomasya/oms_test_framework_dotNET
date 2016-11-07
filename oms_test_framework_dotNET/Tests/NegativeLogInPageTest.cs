using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class NegativeLogInPageTest : TestRunner
    {
        private const string ValidName = "iva";
        private const string ValidPassword = "qwerty";
        private const string EmptyField = "";

        [TestMethod]
        public void TestEmptyFieldsLogIn()
        {
                userInfoPage = logInPage.LogInAs(EmptyField, EmptyField);

            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }

        [TestMethod]
        public void TestEmptyUserNameLogIn()
        {
                userInfoPage = logInPage.LogInAs(EmptyField, ValidPassword);

            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }

        [TestMethod]
        public void TestEmptyPasswordLogIn()
        {
                userInfoPage = logInPage.LogInAs(ValidName, EmptyField);

            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }

        [TestMethod]
        public void TestInvalidLogIn()
        {
                userInfoPage = logInPage.LogInAs(Roles.INVALID_USER);

            AssertThat(userInfoPage.userInfoFieldSet).TextEquals("User Info");
        }
    }
}
