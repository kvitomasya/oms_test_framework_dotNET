using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class ItemManagementPage : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//table[@id='table']/tbody/tr[1]/td[4]/a")]
        public IWebElement EditFirstProductLink { get; set; }

        [FindsBy(How = How.Id, Using = "searchField")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='searchForm']/input[2]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='table']/tbody/tr[1]/td[1]")]
        public IWebElement FirstProductNameText { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='table']/tbody/tr[1]/td[2]")]
        public IWebElement FirstProductDescriptionText { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@id='table']/tbody/tr[1]/td[3]")]
        public IWebElement FirstProductPriceText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='recordsFound']")]
        public IWebElement CountOfProductFound { get; set; }

        // SearchByTextLabel is unique ItemManagementPage element
        [FindsBy(How = How.XPath, Using = "//div[@id='list']//legend")]
        public IWebElement SearchByTextLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/a[1]")]
        public IWebElement AddProductLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='list']/a[2]"]
        public IWebElement CreateReportLink { get; set; }

        public ItemManagementPage(IWebDriver driver) : base(driver)
        {
        }

        public EditProductPage ClickEditFirstProductLink()
        {
            EditFirstProductLink.Click();
            return new EditProductPage(Driver);
        }

        public ItemManagementPage FillSearchInput(String searchText)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(searchText);
            return this;
        }

        public ItemManagementPage ClickSearchButton()
        {
            SearchButton.Click();
            return this;
        }

        public AddProductPage ClickAddProductLink()
        {
            AddProductLink.Click();
            return new AddProductPage(Driver);
        }

        public SupervisorCreateReportPage ClickCreateReportLink()
        {
            CreateReportLink.Click();
            return new SupervisorCreateReportPage(Driver);
        }
    }

}
