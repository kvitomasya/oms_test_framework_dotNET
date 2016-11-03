using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministrationPage : PageObject
    {
        internal TextLabel FoundUsersTextLabel;
        internal Link UserInfoLink;
        internal Link CreateNewUserLink;
        internal Link CreateReportLink;
        internal Link EditFirstUserLink;
        internal Link DeleteUserCell;
        internal DropDown FieldFilter;
        internal DropDown ConditionFilter;
        internal TextInputField SearchInputField;
        internal Button SearchButton;
        internal Link DeleteFirstCellLink;
        internal Link LogInFirstCellLink;
        internal Button FirstNameHeader;
        internal Button LastNameHeader;
        internal Button LoginHeader;
        internal Button RoleHeader;
        internal Button RegionHeader;
        internal Link LoginSecondCellLink;
        internal Element FirstNameColumn;
        internal Element LastNameColumn;
        internal Element LoginColumn;
        internal Element RoleColumn;
        internal Element RegionColumn;

        public AdministrationPage(IWebDriver driver) : base(driver)
        {
            // FoundUsersTextLabel is unique identifier of AdministrationPage
            FoundUsersTextLabel = new TextLabel(Driver, new Locator("FoundUsersTextLabel",
                By.XPath("//div[@id='list']/h4[1]")));

            UserInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            CreateNewUserLink = new Link(Driver, new Locator("CreateNewUserLink",
                By.XPath("//div[@id='list']/a")));

            CreateReportLink = new Link(Driver, new Locator("CreateReportLink",
                By.XPath("//div[@id='list']/h5/a")));

            EditFirstUserLink = new Link(Driver, new Locator("EditFirstUserLink",
                By.XPath("//table[@id='table']//a[@href='editUser.htm?userID=1']")));

            DeleteUserCell = new Link(Driver, new Locator("DeleteUserCell",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[7]/a")));

            FieldFilter = new DropDown(Driver, new Locator("FieldFilter",
                By.XPath("//*[@id='field']")));

            ConditionFilter = new DropDown(Driver, new Locator("ConditionFilter",
                By.XPath("//*[@id='condition']")));

            SearchInputField = new TextInputField(Driver, new Locator("SearchInputField",
                By.XPath("//*[@id='searchField']")));

            SearchButton = new Button(Driver, new Locator("SearchButton",
                By.XPath("//*[@id='searchForm']/input[2]")));

            DeleteFirstCellLink = new Link(Driver, new Locator("DeleteFirstCellLink",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[7]/a")));

            LogInFirstCellLink = new Link(Driver, new Locator("LoginFirstCellLink",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[3]")));

            FirstNameHeader = new Button(Driver, new Locator("FirstNameHeader",
                By.XPath("//*[@id='table']/thead/tr/th[1]/a")));

            LastNameHeader = new Button(Driver, new Locator("LastNameHeader",
                By.XPath("//*[@id='table']/thead/tr/th[2]/a")));

            LoginHeader = new Button(Driver, new Locator("LoginHeader",
                By.XPath("//*[@id='table']/thead/tr/th[3]/a")));

            RoleHeader = new Button(Driver, new Locator("RoleHeader",
                By.XPath("//*[@id='table']/thead/tr/th[4]/a")));

            RegionHeader = new Button(Driver, new Locator("RegionHeader",
                By.XPath("//*[@id='table']/thead/tr/th[5]/a")));

            LoginSecondCellLink = new Link(Driver, new Locator("LoginSecondCellLink",
                By.XPath("//*[@id='table']/tbody/tr[2]/td[3]")));

            FirstNameColumn = new Element(Driver, new Locator("FirstNameColumn",
                By.XPath("//*[@id='table']/tbody//td[1]")));

            LastNameColumn = new Element(Driver, new Locator("LastNameColumn",
                By.XPath("//*[@id='table']/tbody//td[2]")));

            LoginColumn = new Element(Driver, new Locator("LoginColumn",
                By.XPath("//*[@id='table']/tbody//td[3]")));

            RoleColumn = new Element(Driver, new Locator("RoleColumn",
                By.XPath("//*[@id='table']/tbody//td[4]")));

            RegionColumn = new Element(Driver, new Locator("RegionColumn",
                By.XPath("//*[@id='table']/tbody//td[5]")));
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
