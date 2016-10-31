using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddItemPage : PageObject
    {
        // ResetButton is unique identifier of AddItemPage
        Link ResetButton = new Button(Driver , new Locator("ResetButton",
            By.XPath("//form[@id='resetForm']/input[11]")));
        //[FindsBy(How = How.XPath, Using = "//form[@id='resetForm']/input[11]")]
        //public IWebElement ResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/descendant::form[contains(@id, 'selectFrom')][1]/a")]
        public IWebElement SelectFirstItemLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='content']/fieldset/fieldset/table/tbody/tr/td[2]/input")]
        public IWebElement DoneButton { get; set; }

        public AddItemPage(IWebDriver driver) : base(driver)
        {

        }

        public AddItemPage ClickSelectFirstItemLink()
        {
            SelectFirstItemLink.Click();
            return this;
        }

        public CreateNewOrderPage ClickDoneButton()
        {
            DoneButton.Click();
            return new CreateNewOrderPage(Driver);
        }
    }
}
