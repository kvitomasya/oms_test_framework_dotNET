using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateUserPage : PageObject
    {
        //Unique CreateUserPage Web Element
        [FindsBy(How = How.XPath, Using = "//*[@id='userModel']/table/tbody/tr[1]/td[1]")]
        public IWebElement LoginNameLabel { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement LoginInput { get; set; }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement FirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        public IWebElement ConfirmPasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ProductNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "regionID")]
        public IWebElement RegionIdCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "roleID")]
        public IWebElement RoleCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='userModel']/input[4]")]
        public IWebElement CreateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='userModel']/input[5]")]
        public IWebElement CancelButton { get; set; }

        public CreateUserPage(IWebDriver driver) : base(driver)
        {
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
            RegionIdCheckBox.SendKeys(region);
            return this;
        }

        public CreateUserPage ChooseRole(string role)
        {
            RoleCheckBox.SendKeys(role);
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
