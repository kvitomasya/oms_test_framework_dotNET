using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserOrderingPage : PageObject
    {
        internal TextLabel searchByText;
        internal Link userInfoLink;
        internal Link editFirstOrderLink;
        internal DropDown searchDropdown;
        internal TextInputField searchInput;
        internal Button applyButton;
        internal Link firstOrderNameCell;
        internal Link firstOrderDeleteCell;

        public MerchandiserOrderingPage(IWebDriver driver) : base(driver)
        {
            //SearchByText is unique identifier of MerchandiserOrderingPage
            searchByText = new TextLabel(Driver, new Locator("SeachByText",
                By.XPath("//form[@id='searchFilter']//tr/td[1]")));

            userInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            editFirstOrderLink = new Link(Driver, new Locator("EditFirstOrderLink",
                By.XPath("//div[@id='list']//tr[2]/td[6]/a")));

            searchDropdown = new DropDown(Driver, new Locator("SearchDropDown",
                By.XPath("//select[@id='search']")));

            searchInput = new TextInputField(Driver, new Locator("SearchInput", By.Id("searchValue")));

            applyButton = new Button(Driver, new Locator("ApplyButton",
                By.XPath("//form[@id='searchFilter']//td[4]/input")));

            firstOrderNameCell = new Link(Driver, new Locator("FirstOrderNameCell",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[1]")));

            firstOrderDeleteCell = new Link(Driver, new Locator("FirstOrderDeleteCell",
                By.XPath("//div[@id='list']/table/tbody/tr[2]/td[7]/a")));
        }

        public UserInfoPage ClickUserInfoLink()
        {
            userInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public MerchandiserEditOrderPage ClickEditFirstOrderLink()
        {
            editFirstOrderLink.Click();
            return new MerchandiserEditOrderPage(Driver);
        }

        public MerchandiserOrderingPage SelectSearchDropdown(String condition)
        {
            searchDropdown.SendKeys(condition);
            return this;
        }

        public MerchandiserOrderingPage FillSearchInput(String searchText)
        {
            searchInput.SendKeys(searchText);
            return this;
        }

        public MerchandiserOrderingPage ClickApplyButton()
        {
            applyButton.Submit();
            return this;
        }

        public MerchandiserOrderingPage ClickDeleteFirstOrderLink()
        {
            firstOrderDeleteCell.Click();
            return this;
        }
    }
}
