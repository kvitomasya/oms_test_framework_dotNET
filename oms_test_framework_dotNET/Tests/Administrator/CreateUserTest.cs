using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.DBHelpers;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class CreateUserTest : TestRunner
    {
        private string userLogin = "StefDevis";
        private int createdUserId;

        [TestMethod]
        public void TestCreateNewUserAbility()
        {
            administrationPage = logInPage
                     .LogInAs(Roles.ADMINISTRATOR)
                     .ClickAdministrationLink();

            AssertThat(administrationPage.foundUsersTextLabel).IsDisplayed();

            createUserPage = administrationPage.ClickCreateNewUser();

            AssertThat(createUserPage.loginNameLabel).IsDisplayed();

            createUserPage
            .FillLoginField(userLogin)
            .FillFirstNameField("Stef")
            .FillLastNameField("Devis")
            .FillPasswordField("qwerty")
            .FillConfirmPasswordField("qwerty")
            .FillEmailField("StefDevis@gmail.com")
            .ChooseRegion("North")
            .ChooseRole("Customer");

            createUserPage.ClickCreateButton();

            createdUserId = DBUserHandler.GetUserByLogin(userLogin).Id;

            AssertThat(administrationPage.foundUsersTextLabel).IsDisplayed();

            administrationPage
                .FillFieldFilter("Login")
                .FillConditionFilter("equal")
                .FillSearchInputField("StefDevis")
                .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals("StefDevis");

            administrationPage.DeleteUserByLogIn("StefDevis");
        }

        [TestCleanup]
        public void TearDown()
        {
            DBUserHandler.DeleteUser(createdUserId);
        }
    }
}
