using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateUserPage : PageObject
    {
        internal TextLabel LoginNameLabel;
        internal TextInputField LoginInput;
        internal TextInputField FirstNameInput;
        internal TextInputField LastNameInput;
        internal TextInputField PasswordInput;
        internal TextInputField ConfirmPasswordInput;
        internal TextInputField EmailInput;
        internal TextInputField ProductNameInput;
        internal DropDown RegionIdDropDown;
        internal DropDown RoleDropDown;
        internal Button CancelButton;
        internal Button CreateButton;

        public CreateUserPage(IWebDriver driver) : base(driver)
        {
            //Unique CreateUserPage Web Element
            LoginNameLabel = new TextLabel(Driver, new Locator("LoginNameLabel",
                By.XPath("//*[@id='userModel']/table/tbody/tr[1]/td[1]")));

            LoginInput = new TextInputField(Driver, new Locator("LoginInput", By.Id("login")));

            FirstNameInput = new TextInputField(Driver, new Locator("FirstNameInput",
                By.Id("firstName")));

            LastNameInput = new TextInputField(Driver, new Locator("LastNameInput", By.Id("lastName")));

            PasswordInput = new TextInputField(Driver, new Locator("PasswordInput", By.Id("password")));

            ConfirmPasswordInput = new TextInputField(Driver, new Locator("ConfirmPasswordInput",
                By.Id("confirmPassword")));

            EmailInput = new TextInputField(Driver, new Locator("EmailInput", By.Id("email")));

            ProductNameInput = new TextInputField(Driver, new Locator("ProductNameInput",
                By.Id("name")));

            RegionIdDropDown = new DropDown(Driver, new Locator("RegionIdDropDown",
                By.Id("regionID")));

            RoleDropDown = new DropDown(Driver, new Locator("RoleDropDown", By.Id("roleID")));

            CreateButton = new Button(Driver, new Locator("CreateButton",
                By.XPath("//*[@id='userModel']/input[4]")));

            CancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//*[@id='userModel']/input[5]")));
        }

        public CreateUserPage FillLoginField(string login)
        {
            LoginInput.SendKeys(login);
            return this;
        }

        public CreateUserPage FillFirstNameField(string firstName)
        {
            FirstNameInput.SendKeys(firstName);
            return this;
        }

        public CreateUserPage FillLastNameField(string lastName)
        {
            LastNameInput.SendKeys(lastName);
            return this;
        }

        public CreateUserPage FillPasswordField(string password)
        {
            PasswordInput.SendKeys(password);
            return this;
        }

        public CreateUserPage FillConfirmPasswordField(string confirmPassword)
        {
            ConfirmPasswordInput.SendKeys(confirmPassword);
            return this;
        }

        public CreateUserPage FillEmailField(string email)
        {
            EmailInput.SendKeys(email);
            return this;
        }

        public CreateUserPage ChooseRegion(string region)
        {
            RegionIdDropDown.SendKeys(region);
            return this;
        }

        public CreateUserPage ChooseRole(string role)
        {
            RoleDropDown.SendKeys(role);
            return this;
        }

        public AdministrationPage ClickCreateButton()
        {
            CreateButton.Click();
            return new AdministrationPage(Driver);
        }

        public CreateUserPage ClickCancelButton()
        {
            CancelButton.Click();
            return this;
        }
    }
}
