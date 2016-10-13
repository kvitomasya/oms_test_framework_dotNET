using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using oms_test_framework_dotNET.PageObject;

namespace oms_test_framework_dotNET.Utils
{
    [TestClass]
    public class TestRunner
    {
        private const String OmsURL = "http://192.168.56.101:8080/oms5/login.htm";

        protected AddItemPage addItemPage;
        protected AddProductPage addProductPage;
        protected AdministrationPage administrationPage;
        protected AdministratorCreateReportPage administratorCreateReportPage;
        protected AdministratorReportPage administratorReportPage;
        protected CreateNewOrderPage createNewOrderPage;
        protected CreateNewUserPage createNewUserPage;
        protected CustomerOrderingPage customerOrderingPage;
        protected EditProductPage editProductPage;
        protected EditUserPage editUserPage;
        protected ItemManagementPage itemManagementPage;
        protected LogInPage logInPage;
        protected MerchandiserEditOrderPage merchandiserEditOrderPage;
        protected MerchandiserOrderingPage merchandiserOrderingPage;
        protected OrderItemsErrorMessagePage orderItemsErrorMessagePage;
        protected SupervisorCreateReportPage supervisorCreateReportPage;
        protected SupervisorReportPage supervisorReportPage;
        protected UserInfoPage userInfoPage;

        protected IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new FirefoxDriver();
         
            Driver.Manage()
                .Timeouts()
                .ImplicitlyWait(TimeSpan.FromSeconds(10));

            Driver.Manage()
                .Window
                .Maximize();

            Driver.Url = OmsURL;

            logInPage = new LogInPage(Driver);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Quit();
        }
    }

}
