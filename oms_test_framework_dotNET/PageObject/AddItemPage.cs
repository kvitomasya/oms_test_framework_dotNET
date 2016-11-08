using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddItemPage : PageObject
    {
       internal Button resetButton;
       internal Link selectFirstItemLink;
       internal Button doneButton;

        public AddItemPage(IWebDriver driver) : base(driver)
        {
            // ResetButton is unique identifier of AddItemPage
            resetButton = new Button(Driver, new Locator("ResetButton",
                By.XPath("//form[@id='resetForm']/input[11]")));

            selectFirstItemLink = new Link(Driver, new Locator("SelectFirstItemLink",
                By.XPath("//div[@id='list']/descendant::form[contains(@id, 'selectFrom')][1]/a")));

            doneButton = new Button(Driver, new Locator("DoneButton",
                By.XPath("//div[@id='content']/fieldset/fieldset/table/tbody/tr/td[2]/input")));
        }
        
        public AddItemPage ClickSelectFirstItemLink()
        {
            selectFirstItemLink.Click();
            return this;
        }

        public CreateNewOrderPage ClickDoneButton()
        {
            doneButton.Click();
            return new CreateNewOrderPage(Driver);
        }
    }
}
