using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using oms_test_framework_dotNET.PageObject;

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

        protected IWebDriver Driver { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
         
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
