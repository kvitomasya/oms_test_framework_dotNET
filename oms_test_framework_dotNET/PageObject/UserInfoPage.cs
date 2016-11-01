using oms_test_framework_dotNET.Locators;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class UserInfoPage : PageObject
    {
        internal TextLabel UserInfoFieldSet;
        internal Link AdministrationLink;
        internal Link CustomerOrderingLink;
        internal Link MerchandiserOrderingLink;
        internal Link ItemManagementLink;
        internal Link UserInfoLink;

        public UserInfoPage(IWebDriver driver) : base(driver)
        {
            // UserInfoFieldSet is unique element on UserInfoPage
            UserInfoFieldSet = new TextLabel(Driver, new Locator("UserInfoFieldSet",
                By.XPath("//div[@id='content']//legend")));

            AdministrationLink = new Link(Driver, new Locator("AdministrationLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='users.htm']")));

            CustomerOrderingLink = new Link(Driver, new Locator("CustomerOrderingLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='order.htm']")));

            MerchandiserOrderingLink = new Link(Driver, new Locator("MerchandiserOrderingLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='order.htm']")));

            ItemManagementLink = new Link(Driver, new Locator("ItemManagementLink",
                By.XPath("//ul[@id='nav']/descendant::a[@href='itemManagement.htm']")));

            UserInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));
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
