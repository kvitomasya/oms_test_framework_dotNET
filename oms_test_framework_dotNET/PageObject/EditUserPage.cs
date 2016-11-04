using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class EditUserPage : PageObject
    {
        internal TextInputField confirmPasswordText;

        public EditUserPage(IWebDriver driver) : base(driver)
        {
            // ConfirmPasswordText is unique identifier of EditUserPage
            confirmPasswordText = new TextInputField(Driver, new Locator("ConfirmPasswordText",
                By.Id("confirmPassword")));
        }
    }
}
