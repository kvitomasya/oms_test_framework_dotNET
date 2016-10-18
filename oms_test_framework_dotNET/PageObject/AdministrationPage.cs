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
    
        [FindsBy(How = How.XPath, Using = "//*[@id='table']/tbody/tr[1]/td[7]/a")]
        public IWebElement DeleteUserCell { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='field']")]
        public IWebElement FieldFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='condition']")]
        public IWebElement ConditionFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchField']")]
        public IWebElement SearchInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchForm']/input[2]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='table']/tbody/tr[1]/td[7]/a")]
        public IWebElement DeleteFirstCellLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='table']/tbody/tr[1]/td[3]")]
        public IWebElement LogInFirstCellLink { get; set; }

        public AdministrationPage(IWebDriver driver) : base(driver)
        {

        }

        public AdministrationPage FillFieldFilter(string filterValue)
        {
            FieldFilter.SendKeys(filterValue);
            return this;
        }

        public AdministrationPage FillConditionFilter(string conditionValue)
        {
            ConditionFilter.SendKeys(conditionValue);
            return this;
        }

        public AdministrationPage FillSearchInputField(string searchValue)
        {
            SearchInputField.SendKeys(searchValue);
            return this;
        }

        public AdministrationPage ClickSearchButton()
        {
            SearchButton.Click();
            return this;
        }

        public AdministrationPage DeleteUserByLogIn(string login)
        {
            FieldFilter.SendKeys("Login");
            ConditionFilter.SendKeys("equals");
            SearchInputField.Clear();
            SearchInputField.SendKeys(login);
            SearchButton.Click();
            DeleteFirstCellLink.Click();
            Driver.SwitchTo().Alert().Accept();
            return this;
        }

        public CreateUserPage ClickCreateNewUser()
        {
            CreateNewUserLink.Click();
            return new CreateUserPage(Driver);
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
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
