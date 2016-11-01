using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserOrderingPage : PageObject
    {
        internal TextLabel SearchByText;
        internal Link UserInfoLink;
        internal Link EditFirstOrderLink;
        internal DropDown SearchDropdown;
        internal TextInputField SearchInput;
        internal Button ApplyButton;
        internal Link FirstOrderNameCell;
        internal Link FirstOrderDeleteCell;

        public MerchandiserOrderingPage(IWebDriver driver) : base(driver)
        {
            //SearchByText is unique identifier of MerchandiserOrderingPage
            SearchByText = new TextLabel(Driver, new Locator("SeachByText",
                By.XPath("//form[@id='searchFilter']//tr/td[1]")));

            UserInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            EditFirstOrderLink = new Link(Driver, new Locator("EditFirstOrderLink",
                By.XPath("//div[@id='list']//tr[2]/td[6]/a")));

            SearchDropdown = new DropDown(Driver, new Locator("SearchDropDown",
                By.XPath("//select[@id='search']")));

            SearchInput = new TextInputField(Driver, new Locator("SearchInput", By.Id("searchValue")));

            ApplyButton = new Button(Driver, new Locator("ApplyButton",
                By.XPath("//form[@id='searchFilter']//td[4]/input")));

            FirstOrderNameCell = new Link(Driver, new Locator("FirstOrderNameCell",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[1]")));

            FirstOrderDeleteCell = new Link(Driver, new Locator("FirstOrderDeleteCell",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[7]/a")));
        }

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public MerchandiserEditOrderPage ClickEditFirstOrderLink()
        {
            EditFirstOrderLink.Click();
            return new MerchandiserEditOrderPage(Driver);
        }

        public MerchandiserOrderingPage SelectSearchDropdown(String condition)
        {
            SearchDropdown.SendKeys(condition);
            return this;
        }

        public MerchandiserOrderingPage FillSearchInput(String searchText)
        {
            SearchInput.SendKeys(searchText);
            return this;
        }

        public MerchandiserOrderingPage ClickApplyButton()
        {
            ApplyButton.Submit();
            return this;
        }

        public MerchandiserOrderingPage ClickDeleteFirstOrderLink()
        {
            FirstOrderDeleteCell.Click();
            return this;
        }
    }
}
