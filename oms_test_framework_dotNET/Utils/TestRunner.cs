
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using oms_test_framework_dotNET.PageObject;
using oms_test_framework_dotNET.Enums;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Extensions;

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
        protected CreateUserPage createUserPage;
        protected CreateNewOrderPage createNewOrderPage;
        protected CreateUserPage createNewUserPage;
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

        protected void OnTestResult(Action action)
        {
            try
            {
                action();
                LoggerNLog log = new LoggerNLog();
                log.LogInfo(action.Target.ToString());
            }
            catch (Exception exception)
            {
                var screenshot = Driver.TakeScreenshot();

                var screenshotFileName = DateTime.Now.ToString("yyyy-MM-dd_H-mm-ss") + ".jpeg";

                var screenshotFilePath = AppDomain.CurrentDomain.BaseDirectory + "/" + "../../logs/screenshots/"
                    + screenshotFileName;

                screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Jpeg);

                LoggerNLog log = new LoggerNLog();
                log.LogFail(exception.Message, action.Target.ToString(), screenshotFileName);

                throw;
            }
        }

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
