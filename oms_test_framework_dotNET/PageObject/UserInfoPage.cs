using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class UserInfoPage : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='itemManagement.htm']")]
        public IWebElement ItemManagementLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul[@id='nav']//a)[1]")]
        public IWebElement CustomerOrderingPageLink { get; set; }

        public UserInfoPage(IWebDriver driver) : base(driver)
        {
        }

        public ItemManagementPage ClickItemManagementLink()
        {
            ItemManagementLink.Click();
            return new ItemManagementPage(Driver);
        }


        public CustomerOrderingPage ClickCustomerOrderingPageLink()
        {
            CustomerOrderingPageLink.Click();
            return new CustomerOrderingPage (Driver);
        }
    }

}
