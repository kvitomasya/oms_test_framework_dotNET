using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using oms_test_framework_dotNET.Utils;
using System.Diagnostics;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {

        [TestInitialize]
        public void SetUpTest()
        {           
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {
            OnTestResult(() =>
            {
                itemManagementPage = userInfoPage.ClickItemManagementLink();
                Assert.IsTrue(itemManagementPage.SearchByFieldSet.Displayed, "Current page is not {0}", itemManagementPage);
                itemManagementPage.ClickUserInfoLink();
                Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed, "Current page is not {0}", userInfoPage);
            });
        }
    }
}
