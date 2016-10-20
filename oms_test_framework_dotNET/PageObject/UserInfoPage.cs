using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class UserInfoPage : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='users.htm']")]
        public IWebElement AdministrationLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='order.htm']")]
        public IWebElement CustomerOrderingLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='order.htm']")]
        public IWebElement MerchandiserOrderingLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='itemManagement.htm']")]
        public IWebElement ItemManagementLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }
        // UserInfoFieldSet is unique element on UserInfoPage
        [FindsBy(How = How.XPath, Using = "//div[@id='content']//legend")]
        public IWebElement UserInfoFieldSet { get; set; }

        public UserInfoPage(IWebDriver driver)
            : base(driver)
        {

        }

        public AdministrationPage ClickAdministrationLink()
        {
            AdministrationLink.Click();
            return new AdministrationPage(Driver);
        }

        public CustomerOrderingPage ClickCustomerOrderingLink()
        {
            CustomerOrderingLink.Click();
            return new CustomerOrderingPage(Driver);
        }

        public MerchandiserOrderingPage ClickMerchandiserOrderingLink()
        {
            MerchandiserOrderingLink.Click();
            return new MerchandiserOrderingPage(Driver);
        }

        public ItemManagementPage ClickItemManagementLink()
        {
            ItemManagementLink.Click();
            return new ItemManagementPage(Driver);
        }

        public CustomerOrderingPage ClickCustomerOrdetingLink()
        {
            CustomerOrderingLink.Click();
            return new CustomerOrderingPage(Driver);
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }
    }
}
