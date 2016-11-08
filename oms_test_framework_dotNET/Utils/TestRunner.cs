using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using oms_test_framework_dotNET.PageObject;
using oms_test_framework_dotNET.Enums;
using System.Drawing.Imaging;
using System.IO;
using static oms_test_framework_dotNET.Utils.LoggerNLog;

namespace oms_test_framework_dotNET.Utils
{
    [TestClass]
    public class TestRunner
    {
        public TestContext TestContext { get; set; }

        private const String OmsURL = "http://192.168.56.101:8080/oms5/login.htm";

        protected AddItemPage addItemPage;
        protected AddProductPage addProductPage;
        protected AdministrationPage administrationPage;
        protected AdministratorCreateReportPage administratorCreateReportPage;
        protected AdministratorReportPage administratorReportPage;
        protected CreateUserPage createUserPage;
        protected CreateNewOrderPage createNewOrderPage;
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

            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                LogInfo(TestContext.TestName);
            }
            else
            {
                Screenshot screenShot = ((ITakesScreenshot)Driver).GetScreenshot();

                String screenshotFileName = DateTime.Now.ToString("yyyy-MM-dd_H-mm-ss") + ".png";

                LogFail(TestContext.CurrentTestOutcome.ToString(), TestContext.TestName, screenshotFileName);

                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/" + "../../logs/screenshots/");

                String screenshotFilePath = AppDomain.CurrentDomain.BaseDirectory + "/" + "../../logs/screenshots/"
                                            + screenshotFileName;

                screenShot.SaveAsFile(screenshotFilePath, ImageFormat.Png);
            }

            Driver.Quit();
        }
    }
}
