using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class LogOutTest : TestRunner
    {

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
            itemManagementPage = userInfoPage.ClickItemManagementLink();
        }

        [TestMethod]
        public void TestItemManagementPageLogOutAbility()
        {
            Assert.IsTrue(itemManagementPage.searchByFieldSet.IsDisplayed(),
                "Item Management page doesn't exist");
            itemManagementPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestSupervisorCreateReportPageLogOutAbility()
        {
            supervisorCreateReportPage = itemManagementPage.ClickCreateReportLink();
            Assert.IsTrue(supervisorCreateReportPage.saveReportLink.IsDisplayed(),
                "Supervisor create report page doesn't exist");
            supervisorCreateReportPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestAddProductPageLogOutAbility()
        {
            addProductPage = itemManagementPage.ClickAddProductLink();
            Assert.IsTrue(addProductPage.okButton.IsDisplayed(),
                "Add product page doesn't exist");
            addProductPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestEditProductPageLogOutAbility()
        {
            editProductPage = itemManagementPage.ClickEditFirstProductLink();
            Assert.IsTrue(editProductPage.okButton.IsDisplayed(),
                "Edit product page doesn't exist");
            editProductPage.DoLogOut();
            Assert.IsTrue(logInPage.usernameInput.IsDisplayed(),
                "Logout is not working");
        }
    }
}
