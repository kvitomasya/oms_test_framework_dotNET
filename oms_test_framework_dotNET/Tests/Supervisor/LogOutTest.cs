using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

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
            AssertThat(itemManagementPage.searchByFieldSet).IsDisplayed();

            itemManagementPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestSupervisorCreateReportPageLogOutAbility()
        {
            supervisorCreateReportPage = itemManagementPage.ClickCreateReportLink();

            AssertThat(supervisorCreateReportPage.saveReportLink).IsDisplayed();

            supervisorCreateReportPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestAddProductPageLogOutAbility()
        {
            addProductPage = itemManagementPage.ClickAddProductLink();

            AssertThat(addProductPage.okButton).IsDisplayed();

            addProductPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }

        [TestMethod]
        public void TestEditProductPageLogOutAbility()
        {
            editProductPage = itemManagementPage.ClickEditFirstProductLink();

            AssertThat(editProductPage.okButton).IsDisplayed();

            editProductPage.DoLogOut();

            AssertThat(logInPage.usernameInput).IsDisplayed();
        }
    }
}
