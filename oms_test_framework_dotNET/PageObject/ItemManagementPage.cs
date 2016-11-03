using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class ItemManagementPage : PageObject
    {
        internal Link EditFirstProductLink;
        internal TextInputField SearchInput;
        internal Button SearchButton;
        internal Link FirstProductNameText;
        internal Link FirstProductDescriptionText;
        internal Link FirstProductPriceText;
        internal TextLabel CountOfProductFound;
        internal TextLabel SearchByFieldSet;
        internal Link UserInfoLink;
        internal Link AddProductLink;
        internal Link CreateReportLink;

        public ItemManagementPage(IWebDriver driver) : base(driver)
        {
            // SearchByFieldSet is unique identifier of ItemManagementPage
            SearchByFieldSet = new TextLabel(Driver, new Locator("SearchByFieldSet",
                By.XPath("//div[@id='list']//legend")));

            EditFirstProductLink = new Link(Driver, new Locator("EditFirstProductLink",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[4]/a")));

            SearchInput = new TextInputField(Driver, new Locator("SearchInput", By.Id("searchField")));

            SearchButton = new Button(Driver, new Locator("SearchButton",
                By.XPath("//form[@id='searchForm']/input[2]")));

            FirstProductNameText = new Link(Driver, new Locator("FirstProductNameText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[1]")));

            FirstProductDescriptionText = new Link(Driver, new Locator("FirstProductDescriptionText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[2]")));

            FirstProductPriceText = new Link(Driver, new Locator("FirstProductPriceText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[3]")));

            CountOfProductFound = new TextLabel(Driver, new Locator("CountOfProductFound",
                By.XPath("//span[@id='recordsFound']")));

            UserInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            AddProductLink = new Link(Driver, new Locator("AddProductLink",
                By.XPath("//div[@id='list']/a[1]")));

            CreateReportLink = new Link(Driver, new Locator("CreateReportLink",
                By.XPath("//div[@id='list']/a[2]")));
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

        public UserInfoPage ClickUserInfoLink()
        {
            UserInfoLink.Click();
            return new UserInfoPage(Driver);
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
