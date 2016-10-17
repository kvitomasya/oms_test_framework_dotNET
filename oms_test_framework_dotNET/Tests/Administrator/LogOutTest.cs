using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            const String AdministratorLogin = "iva";
            const String AdministratorPassword = "qwerty";
            userInfoPage = logInPage.LogInAs(AdministratorLogin, AdministratorPassword);
            administrationPage = userInfoPage.ClickAdministrationLink();
        }

        [TestMethod]
        public void TestAdministrationPageLogOutAbility()
        {
            Assert.IsTrue(administrationPage.FoundUsersTextLabel.Displayed,
                "Administration page doesn't exist");
            administrationPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestCreateReportPageLogOutAbility()
        {
            administratorCreateReportPage = administrationPage.ClickCreateReportLink();
            Assert.IsTrue(administratorCreateReportPage.SaveReportLink.Displayed,
                "Create Report page doesn't exist");
            administratorCreateReportPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestCreateNewUserPageLogOutAbility()
        {
            createNewUserPage = administrationPage.ClickCreateNewUserLink();
            Assert.IsTrue(createNewUserPage.PageInfoText.Displayed,
                "Create new user page doesn't exists");
            createNewUserPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }

        [TestMethod]
        public void TestEditUserPageLogOutAbility()
        {
            editUserPage = administrationPage.ClickEditFirstUserLink();
            Assert.IsTrue(editUserPage.ConfirmPasswordText.Displayed,
                "Edit user page doesn't exists");
            editUserPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.Displayed,
                "Logout is not working");
        }
    }
}
