using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class CreateUserTest : TestRunner
    {
        [TestMethod]
        public void TestCreateNewUserAbility()
        {          
            administrationPage = logInPage
                     .LogInAs(Roles.ADMINISTRATOR)
                     .ClickAdministrationLink();

            Assert
                .IsTrue(administrationPage.FoundUsersTextLabel.Displayed,
                "The Admin page should be displayed!");

            createUserPage = administrationPage.ClickCreateNewUser();

            Assert
                .IsTrue(createUserPage.LoginNameLabel.Displayed,
                "The CreateNewUserPage should be displayed!");

            createUserPage
            .FillLoginField("StefDevis")
            .FillFirstNameField("Stef")
            .FillLastNameField("Devis")
            .FillPasswordField("qwerty")
            .FillConfirmPasswordField("qwerty")
            .FillEmailField("StefDevis@gmail.com")
            .ChooseRegion("North")
            .ChooseRole("Customer");

            createUserPage.ClickCreateButton();

            Assert
                .IsTrue(administrationPage.FoundUsersTextLabel.Displayed,
                "The Admin page should be displayed!");

            administrationPage
                .FillFieldFilter("Login")
                .FillConditionFilter("equal")
                .FillSearchInputField("StefDevis")
                .ClickSearchButton();

            Assert
                .AreEqual("StefDevis", administrationPage.LogInFirstCellLink.Text,
                "As a result of the search should be a user with the specified login");

            administrationPage.DeleteUserByLogIn("StefDevis");
        }
    }
}

