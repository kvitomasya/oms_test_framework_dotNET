using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class ItemManagementPage : PageObject
    {
        internal Link editFirstProductLink;
        internal TextInputField searchInput;
        internal Button searchButton;
        internal Link firstProductNameText;
        internal Link firstProductDescriptionText;
        internal Link firstProductPriceText;
        internal TextLabel countOfProductFound;
        internal TextLabel searchByFieldSet;
        internal Link userInfoLink;
        internal Link addProductLink;
        internal Link createReportLink;

        public ItemManagementPage(IWebDriver driver) : base(driver)
        {
            // SearchByFieldSet is unique identifier of ItemManagementPage
            searchByFieldSet = new TextLabel(Driver, new Locator("SearchByFieldSet",
                By.XPath("//div[@id='list']//legend")));

            editFirstProductLink = new Link(Driver, new Locator("EditFirstProductLink",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[4]/a")));

            searchInput = new TextInputField(Driver, new Locator("SearchInput", By.Id("searchField")));

            searchButton = new Button(Driver, new Locator("SearchButton",
                By.XPath("//form[@id='searchForm']/input[2]")));

            firstProductNameText = new Link(Driver, new Locator("FirstProductNameText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[1]")));

            firstProductDescriptionText = new Link(Driver, new Locator("FirstProductDescriptionText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[2]")));

            firstProductPriceText = new Link(Driver, new Locator("FirstProductPriceText",
                By.XPath("//table[@id='table']/tbody/tr[1]/td[3]")));

            countOfProductFound = new TextLabel(Driver, new Locator("CountOfProductFound",
                By.XPath("//span[@id='recordsFound']")));

            userInfoLink = new Link(Driver, new Locator("UserInfoLink",
                By.XPath("//ul[@id='nav']/li[2]/a")));

            addProductLink = new Link(Driver, new Locator("AddProductLink",
                By.XPath("//div[@id='list']/a[1]")));

            createReportLink = new Link(Driver, new Locator("CreateReportLink",
                By.XPath("//div[@id='list']/a[2]")));
        }

        public EditProductPage ClickEditFirstProductLink()
        {
            editFirstProductLink.Click();
            return new EditProductPage(Driver);
        }

        public ItemManagementPage FillSearchInput(String searchText)
        {
            searchInput.Clear();
            searchInput.SendKeys(searchText);
            return this;
        }

        public ItemManagementPage ClickSearchButton()
        {
            searchButton.Click();
            return this;
        }

        public UserInfoPage ClickUserInfoLink()
        {
            userInfoLink.Click();
            return new UserInfoPage(Driver);
        }

        public AddProductPage ClickAddProductLink()
        {
            addProductLink.Click();
            return new AddProductPage(Driver);
        }

        public SupervisorCreateReportPage ClickCreateReportLink()
        {
            createReportLink.Click();
            return new SupervisorCreateReportPage(Driver);
        }
    }
}
