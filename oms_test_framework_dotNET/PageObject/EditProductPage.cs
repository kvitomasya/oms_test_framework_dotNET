using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class EditProductPage : PageObject
    {
        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ProductNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "description")]
        public IWebElement ProductDescriptionInput { get; set; }

        [FindsBy(How = How.Id, Using = "price")]
        public IWebElement ProductPriceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/input[2]")]
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/input[3]")]
        public IWebElement CancelButton { get; set; }

        public EditProductPage(IWebDriver driver) : base(driver)
        {
        }

        public EditProductPage FillProductNameInput(String productName)
        {
            ProductNameInput.Clear();
            ProductNameInput.SendKeys(productName);
            return this;
        }

        public EditProductPage FillProductDescriptionInput(String productDescription)
        {
            ProductDescriptionInput.Clear();
            ProductDescriptionInput.SendKeys(productDescription);
            return this;
        }

        public EditProductPage FillProductPriceInput(String productPrice)
        {
            ProductPriceInput.Clear();
            ProductPriceInput.SendKeys(productPrice);
            return this;
        }

        public ItemManagementPage ClickOkButton()
        {
            OkButton.Click();
            return new ItemManagementPage(Driver);
        }

        public ItemManagementPage ClickCancelButton()
        {
            CancelButton.Click();
            return new ItemManagementPage(Driver);
        }
    }

}
