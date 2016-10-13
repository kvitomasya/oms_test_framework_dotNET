using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class SwitchTabsTest : TestRunner
    {       
        private const string AdministratorLogin = "iva";
        private const string AdministratorPassword = "qwerty";
        
        [TestInitialize]
        public void SetUpTest()
        {
            
            userInfoPage = logInPage.LogInAs(AdministratorLogin, AdministratorPassword);

        }

        [TestMethod]
        public void TestSwitchTabsAbility()
        {

            administrationPage =  userInfoPage.ClickAdministrationLink();
            Assert.IsTrue(administrationPage.FoundUserTextLabel.Displayed);
            administrationPage.ClickUserInfoLink();
            Assert.IsTrue(userInfoPage.UserInfoFieldSet.Displayed);
            
        }
        }
    }