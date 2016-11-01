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
            Assert.IsTrue(itemManagementPage.SearchByFieldSet.IsDisplayed(),
                "Item Management page doesn't exist");
            itemManagementPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestSupervisorCreateReportPageLogOutAbility()
        {
            supervisorCreateReportPage = itemManagementPage.ClickCreateReportLink();
            Assert.IsTrue(supervisorCreateReportPage.SaveReportLink.IsDisplayed(),
                "Supervisor create report page doesn't exist");
            supervisorCreateReportPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestAddProductPageLogOutAbility()
        {
            addProductPage = itemManagementPage.ClickAddProductLink();
            Assert.IsTrue(addProductPage.OkButton.IsDisplayed(),
                "Add product page doesn't exist");
            addProductPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }

        [TestMethod]
        public void TestEditProductPageLogOutAbility()
        {
            editProductPage = itemManagementPage.ClickEditFirstProductLink();
            Assert.IsTrue(editProductPage.OkButton.IsDisplayed(),
                "Edit product page doesn't exist");
            editProductPage.DoLogOut();
            Assert.IsTrue(logInPage.UsernameInput.IsDisplayed(),
                "Logout is not working");
        }
    }
}
