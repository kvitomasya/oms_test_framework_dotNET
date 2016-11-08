using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class AdministrationPage : PageObject
    {
        internal TextLabel foundUsersTextLabel;
        internal Link userInfoLink;
        internal Link createNewUserLink;
        internal Link createReportLink;
        internal Link editFirstUserLink;
        internal Link deleteUserCell;
        internal DropDown fieldFilter;
        internal DropDown conditionFilter;
        internal TextInputField searchInputField;
        internal Button searchButton;
        internal Link deleteFirstCellLink;
        internal Link logInFirstCellLink;
        internal Button firstNameHeader;
        internal Button lastNameHeader;
        internal Button loginHeader;
        internal Button roleHeader;
        internal Button regionHeader;
        internal Link loginSecondCellLink;
        internal Element firstNameColumn;
        internal Element lastNameColumn;
        internal Element loginColumn;
        internal Element roleColumn;
        internal Element regionColumn;

        public AdministrationPage(IWebDriver driver) : base(driver)
        {
            // FoundUsersTextLabel is unique identifier of AdministrationPage
            foundUsersTextLabel = new TextLabel(Driver, new Locator("FoundUsersTextLabel",
                By.XPath("//div[@id='list']/h4[1]")));

            userInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            createNewUserLink = new Link(Driver, new Locator("CreateNewUserLink",
                By.XPath("//div[@id='list']/a")));

            createReportLink = new Link(Driver, new Locator("CreateReportLink",
                By.XPath("//div[@id='list']/h5/a")));

            editFirstUserLink = new Link(Driver, new Locator("EditFirstUserLink",
                By.XPath("//table[@id='table']//a[@href='editUser.htm?userID=1']")));

            deleteUserCell = new Link(Driver, new Locator("DeleteUserCell",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[7]/a")));

            fieldFilter = new DropDown(Driver, new Locator("FieldFilter",
                By.XPath("//*[@id='field']")));

            conditionFilter = new DropDown(Driver, new Locator("ConditionFilter",
                By.XPath("//*[@id='condition']")));

            searchInputField = new TextInputField(Driver, new Locator("SearchInputField",
                By.XPath("//*[@id='searchField']")));

            searchButton = new Button(Driver, new Locator("SearchButton",
                By.XPath("//*[@id='searchForm']/input[2]")));

            deleteFirstCellLink = new Link(Driver, new Locator("DeleteFirstCellLink",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[7]/a")));

            logInFirstCellLink = new Link(Driver, new Locator("LoginFirstCellLink",
                By.XPath("//*[@id='table']/tbody/tr[1]/td[3]")));

            firstNameHeader = new Button(Driver, new Locator("FirstNameHeader",
                By.XPath("//*[@id='table']/thead/tr/th[1]/a")));

            lastNameHeader = new Button(Driver, new Locator("LastNameHeader",
                By.XPath("//*[@id='table']/thead/tr/th[2]/a")));

            loginHeader = new Button(Driver, new Locator("LoginHeader",
                By.XPath("//*[@id='table']/thead/tr/th[3]/a")));

            roleHeader = new Button(Driver, new Locator("RoleHeader",
                By.XPath("//*[@id='table']/thead/tr/th[4]/a")));

            regionHeader = new Button(Driver, new Locator("RegionHeader",
                By.XPath("//*[@id='table']/thead/tr/th[5]/a")));

            loginSecondCellLink = new Link(Driver, new Locator("LoginSecondCellLink",
                By.XPath("//*[@id='table']/tbody/tr[2]/td[3]")));

            firstNameColumn = new Element(Driver, new Locator("FirstNameColumn",
                By.XPath("//*[@id='table']/tbody//td[1]")));

            lastNameColumn = new Element(Driver, new Locator("LastNameColumn",
                By.XPath("//*[@id='table']/tbody//td[2]")));

            loginColumn = new Element(Driver, new Locator("LoginColumn",
                By.XPath("//*[@id='table']/tbody//td[3]")));

            roleColumn = new Element(Driver, new Locator("RoleColumn",
                By.XPath("//*[@id='table']/tbody//td[4]")));

            regionColumn = new Element(Driver, new Locator("RegionColumn",
                By.XPath("//*[@id='table']/tbody//td[5]")));
        }

        public AdministrationPage FillFieldFilter(string filterValue)
        {
            fieldFilter.SendKeys(filterValue);
            return this;
        }

        public AdministrationPage FillConditionFilter(string conditionValue)
        {
            conditionFilter.SendKeys(conditionValue);
            return this;
        }

        public AdministrationPage FillSearchInputField(string searchValue)
        {
            searchInputField.SendKeys(searchValue);
            return this;
        }

        public AdministrationPage ClickSearchButton()
        {
            searchButton.Click();
            return this;
        }

        public AdministrationPage DeleteUserByLogIn(string login)
        {
            fieldFilter.SendKeys("Login");
            conditionFilter.SendKeys("equals");
            searchInputField.Clear();
            searchInputField.SendKeys(login);
            searchButton.Click();
            deleteFirstCellLink.Click();
            Driver.SwitchTo().Alert().Accept();
            return this;
        }

        public CreateUserPage ClickCreateNewUser()
        {
            createNewUserLink.Click();
            return new CreateUserPage(Driver);
        }

        public UserInfoPage ClickUserInfoLink()
        {
            userInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public AdministratorCreateReportPage ClickCreateReportLink()
        {
            createReportLink.Click();
            return new AdministratorCreateReportPage(Driver);
        }

        public EditUserPage ClickEditFirstUserLink()
        {
            editFirstUserLink.Click();
            return new EditUserPage(Driver);
        }
    }
}
