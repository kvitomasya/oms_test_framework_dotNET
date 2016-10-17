using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministrationPage : PageObject
    {
        // FoundUsersTextLabel is unique identifier of AdministrationPage
        [FindsBy(How = How.XPath, Using = "//div[@id='list']/h4[1]")]
        public IWebElement FoundUsersTextLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/a")]
        public IWebElement CreateNewUserLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/h5/a")]
        public IWebElement CreateReportLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='table']//a[@href='editUser.htm?userID=1']")]
        public IWebElement EditFirstUserLink { get; set; }

        public AdministrationPage(IWebDriver driver) : base(driver)
        {

        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public CreateNewUserPage ClickCreateNewUserLink()
        {
            CreateNewUserLink.Click();
            return new CreateNewUserPage(Driver);
        }

        public AdministratorCreateReportPage ClickCreateReportLink()
        {
            CreateReportLink.Click();
            return new AdministratorCreateReportPage(Driver);
        }

        public EditUserPage ClickEditFirstUserLink()
        {
            EditFirstUserLink.Click();
            return new EditUserPage(Driver);
        }
    }
}
