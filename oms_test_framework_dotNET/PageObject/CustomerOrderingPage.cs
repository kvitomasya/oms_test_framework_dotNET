using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 5743ab6fc45fcd53f16cec9cf57ef8dd7e21c43f
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class CustomerOrderingPage : PageObject
    {
<<<<<<< HEAD
        //CreateNewOrderLink is unique identifier of CustomerOrderingPage
        [FindsBy(How = How.XPath, Using = "//div[@id='content']/a")]
        public IWebElement CreateNewOrderLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }
=======

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchOrdersDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "searchValue")]
        public IWebElement SearchOrdersInputField { get; set; }

        [FindsBy(How = How.Name, Using = "Apply")]
        public IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='list']//td/a)[1]")]
        public IWebElement FirstTBodyEditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']//td[1]")]
        public IWebElement FirstTBodyOrderNameTextLable { get; set; }
>>>>>>> 5743ab6fc45fcd53f16cec9cf57ef8dd7e21c43f

        public CustomerOrderingPage(IWebDriver driver) : base(driver)
        {
        }

<<<<<<< HEAD
        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }
    }
}
=======
        public CustomerOrderingPage SelectOrderByName(String searchedOrder)
        {
            SearchOrdersInputField.Clear();
            SearchOrdersInputField.SendKeys(searchedOrder);
            return this;
        }

        public CustomerOrderingPage ClickAplyButton()
        {
            ApplyButton.Click();
            return this;
        }

        public CreateNewOrderPage ClickEditLink()
        {
            FirstTBodyEditLink.Click();
            return new CreateNewOrderPage(Driver);
        }

        public String GetOrderName()
        {
            return FirstTBodyOrderNameTextLable.Text;
        }

    }
}
>>>>>>> 5743ab6fc45fcd53f16cec9cf57ef8dd7e21c43f
