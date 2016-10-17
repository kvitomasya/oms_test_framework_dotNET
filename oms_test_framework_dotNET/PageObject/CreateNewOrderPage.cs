using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
  public  class CreateNewOrderPage : PageObject
    {

        [FindsBy(How = How.XPath, Using = "(//ul[@id='nav']//a)[1]")]
        public IWebElement CustomerOrderingPageLink { get; set; }

        [FindsBy(How = How.Id, Using = "orderNum")]
        public IWebElement OrderNumberInputField { get; set; }

        [FindsBy(How = How.Id, Using = "save")]
        public IWebElement SaveButton { get; set; }

        public CreateNewOrderPage(IWebDriver driver) : base(driver)
        {
        }

        public CreateNewOrderPage ChangeOrderByName(String orderNumber)
        {
            OrderNumberInputField.Clear();
            OrderNumberInputField.SendKeys(orderNumber);
            return this;
        }

        public CreateNewOrderPage ClickSaveButton()
        {
            SaveButton.Click();
            return this;
        }

        public String GetChengedOrderNumber()
        {
            return OrderNumberInputField
                .GetAttribute("Value");
        }


        public CustomerOrderingPage ClickCustomerOrderingPageLink()
        {
            CustomerOrderingPageLink.Click();
            return new CustomerOrderingPage (Driver);
        }
    }
}