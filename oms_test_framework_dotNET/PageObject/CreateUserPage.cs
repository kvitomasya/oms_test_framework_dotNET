using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateUserPage : PageObject
    {
        internal TextLabel loginNameLabel;
        internal TextInputField loginInput;
        internal TextInputField firstNameInput;
        internal TextInputField lastNameInput;
        internal TextInputField passwordInput;
        internal TextInputField confirmPasswordInput;
        internal TextInputField emailInput;
        internal TextInputField productNameInput;
        internal DropDown regionIdDropDown;
        internal DropDown roleDropDown;
        internal Button cancelButton;
        internal Button createButton;

        public CreateUserPage(IWebDriver driver) : base(driver)
        {
            //Unique CreateUserPage Web Element
            loginNameLabel = new TextLabel(Driver, new Locator("LoginNameLabel",
                By.XPath("//*[@id='userModel']/table/tbody/tr[1]/td[1]")));

            loginInput = new TextInputField(Driver, new Locator("LoginInput", By.Id("login")));

            firstNameInput = new TextInputField(Driver, new Locator("FirstNameInput",
                By.Id("firstName")));

            lastNameInput = new TextInputField(Driver, new Locator("LastNameInput", By.Id("lastName")));

            passwordInput = new TextInputField(Driver, new Locator("PasswordInput", By.Id("password")));

            confirmPasswordInput = new TextInputField(Driver, new Locator("ConfirmPasswordInput",
                By.Id("confirmPassword")));

            emailInput = new TextInputField(Driver, new Locator("EmailInput", By.Id("email")));

            productNameInput = new TextInputField(Driver, new Locator("ProductNameInput",
                By.Id("name")));

            regionIdDropDown = new DropDown(Driver, new Locator("RegionIdDropDown",
                By.Id("regionID")));

            roleDropDown = new DropDown(Driver, new Locator("RoleDropDown", By.Id("roleID")));

            createButton = new Button(Driver, new Locator("CreateButton",
                By.XPath("//*[@id='userModel']/input[4]")));

            cancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//*[@id='userModel']/input[5]")));
        }

        public CreateUserPage FillLoginField(string login)
        {
            loginInput.SendKeys(login);
            return this;
        }

        public CreateUserPage FillFirstNameField(string firstName)
        {
            firstNameInput.SendKeys(firstName);
            return this;
        }

        public CreateUserPage FillLastNameField(string lastName)
        {
            lastNameInput.SendKeys(lastName);
            return this;
        }

        public CreateUserPage FillPasswordField(string password)
        {
            passwordInput.SendKeys(password);
            return this;
        }

        public CreateUserPage FillConfirmPasswordField(string confirmPassword)
        {
            confirmPasswordInput.SendKeys(confirmPassword);
            return this;
        }

        public CreateUserPage FillEmailField(string email)
        {
            emailInput.SendKeys(email);
            return this;
        }

        public CreateUserPage ChooseRegion(string region)
        {
            regionIdDropDown.SendKeys(region);
            return this;
        }

        public CreateUserPage ChooseRole(string role)
        {
            roleDropDown.SendKeys(role);
            return this;
        }

        public AdministrationPage ClickCreateButton()
        {
            createButton.Click();
            return new AdministrationPage(Driver);
        }

        public CreateUserPage ClickCancelButton()
        {
            cancelButton.Click();
            return this;
        }
    }
}
