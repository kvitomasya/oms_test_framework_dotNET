using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class MerchandiserOrderingPage : PageObject
    {
        //SearchByText is unique identifier of MerchandiserOrderingPage
        [FindsBy(How = How.XPath, Using = "//form[@id='searchFilter']//tr/td[1]")]
        public IWebElement SearchByText { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public IWebElement UserInfoLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']//tr[2]/td[6]/a")]
        public IWebElement EditFirstOrderLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='search']")]
        public IWebElement SearchDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "searchValue")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='searchFilter']//td[4]/input")]
        public IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/table/tbody/tr[2]/td[1]")]
        public IWebElement FirstOrderNameCell { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/table/tbody/tr[2]/td[7]/a")]
        public IWebElement FirstOrderDeleteCell { get; set; }

        public MerchandiserOrderingPage(IWebDriver driver) : base(driver)
        {
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
