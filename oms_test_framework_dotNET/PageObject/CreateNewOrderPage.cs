using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CreateNewOrderPage : PageObject
    {
        // CVV2Text is unique CreateNewOrderPage element
        [FindsBy(How = How.XPath, Using = "//form[@id='form2']//tr[3]/td[1]/strong")]
        public IWebElement CVV2Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='addItem']/input[@value = 'Add Item']")]
        public IWebElement AddItemButton { get; set; }

        [FindsBy(How = How.Id, Using = "orderNum")]
        public IWebElement OrderNumberField { get; set; }

        [FindsBy(How = How.ClassName, Using = "dp-choose-date")]
        public IWebElement PreferableDeliveryDateChooseLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='dp-popup']")]
        public IWebElement CalendarPopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='dp-popup']/div[2]/a[2]")]
        public IWebElement CalendarMonthForwardButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='dp-popup']//tbody/tr[3]/td[4]")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.Id, Using = "assignee")]
        public IWebElement AssigneeDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "save")]
        public IWebElement SaveButton { get; set; }

        public CreateNewOrderPage(IWebDriver driver) : base(driver)
        {

        }

        public AddItemPage ClickAddItemButton()
        {
            AddItemButton.Click();
            return new AddItemPage(Driver);
        }

        public CreateNewOrderPage ClickPreferableDeliveryDateChooseLink()
        {
            PreferableDeliveryDateChooseLink.Click();
            return this;
        }

        public CreateNewOrderPage ClickCalendarMonthForwardButton()
        {
            CalendarMonthForwardButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickDateLink()
        {
            DateLink.Click();
            return this;
        }

        public CreateNewOrderPage SelectAssigneeDropdown(string AssigneeLogin)
        {
            AssigneeDropdown.SendKeys(AssigneeLogin);
            return this;
        }

        public OrderItemsErrorMessagePage ClickSaveButtonFail()
        {
            SaveButton.Click();
            return new OrderItemsErrorMessagePage(Driver);
        }
    }
}
