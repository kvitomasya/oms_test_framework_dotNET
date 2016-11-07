using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class UserInfoPage : PageObject
    {
        internal TextLabel userInfoFieldSet;
        internal Link administrationLink;
        internal Link customerOrderingLink;
        internal Link merchandiserOrderingLink;
        internal Link itemManagementLink;
        internal Link userInfoLink;

        public UserInfoPage(IWebDriver driver) : base(driver)
        {
            // UserInfoFieldSet is unique element on UserInfoPage
            userInfoFieldSet = new TextLabel(Driver, new Locator("UserInfoFieldSet",
                By.XPath("//div[@id='content']//legend")));

            administrationLink = new Link(Driver, new Locator("AdministrationLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='users.htm']")));

            customerOrderingLink = new Link(Driver, new Locator("CustomerOrderingLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='order.htm']")));

            merchandiserOrderingLink = new Link(Driver, new Locator("MerchandiserOrderingLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='order.htm']")));

            itemManagementLink = new Link(Driver, new Locator("ItemManagementLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='itemManagement.htm']")));

            userInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));
        }

        public AdministrationPage ClickAdministrationLink()
        {
            administrationLink.Click();
            return new AdministrationPage(Driver);
        }

        public CustomerOrderingPage ClickCustomerOrderingLink()
        {
            customerOrderingLink.Click();
            return new CustomerOrderingPage(Driver);
        }

        public MerchandiserOrderingPage ClickMerchandiserOrderingLink()
        {
            merchandiserOrderingLink.Click();
            return new MerchandiserOrderingPage(Driver);
        }

        public ItemManagementPage ClickItemManagementLink()
        {
            itemManagementLink.Click();
            return new ItemManagementPage(Driver);
        }

        public CustomerOrderingPage ClickCustomerOrdetingLink()
        {
            customerOrderingLink.Click();
            return new CustomerOrderingPage(Driver);
        }

        public UserInfoPage ClickUserInfoLink()
        {
            userInfoLink.Click();
            return new UserInfoPage(Driver);
        }
    }
}
