using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddItemPage : PageObject
    {
       internal Button ResetButton;
       internal Link SelectFirstItemLink;
       internal Button DoneButton;

        public AddItemPage(IWebDriver driver) : base(driver)
        {
            // ResetButton is unique identifier of AddItemPage
            ResetButton = new Button(Driver, new Locator("ResetButton",
                By.XPath("//form[@id='resetForm']/input[11]")));

            SelectFirstItemLink = new Link(Driver, new Locator("SelectFirstItemLink",
                By.XPath("//div[@id='list']/descendant::form[contains(@id, 'selectFrom')][1]/a")));

            DoneButton = new Button(Driver, new Locator("DoneButton",
                By.XPath("//div[@id='content']/fieldset/fieldset/table/tbody/tr/td[2]/input")));
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
