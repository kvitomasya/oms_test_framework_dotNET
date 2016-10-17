using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using oms_test_framework_dotNET.PageObject;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Utils
{
    [TestClass]
    public class TestRunner
    {
        private const String OmsURL = "http://192.168.56.101:8080/oms5/login.htm";

        protected LogInPage logInPage;
        protected UserInfoPage userInfoPage;
        protected ItemManagementPage itemManagementPage;
        protected EditProductPage editProductPage;
        protected AdministrationPage administrationPage;
        protected CustomerOrderingPage customerOrderingPage;
        protected MerchandiserOrderingPage merchandiserOrderingPage;
        protected CreateNewOrderPage createNewOrderPage;
        protected IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new WebDriverFactory().GetDriver(Browsers.FIREFOX);
         
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
