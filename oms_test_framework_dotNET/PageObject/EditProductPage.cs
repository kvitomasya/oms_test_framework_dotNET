using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class EditProductPage : PageObject
    {
        internal TextInputField ProductNameInput;
        internal TextInputField ProductDescriptionInput;
        internal TextInputField ProductPriceInput;
        internal Button OkButton;
        internal Button CancelButton;

        public EditProductPage(IWebDriver driver) : base(driver)
        {
            ProductNameInput = new TextInputField(Driver, new Locator("ProductNameInput",
                By.Id("name")));

            ProductDescriptionInput = new TextInputField(Driver, new Locator("ProductDescriptionInput",
                By.Id("description")));

            ProductPriceInput = new TextInputField(Driver, new Locator("ProductPriceInput",
                By.Id("price")));

            OkButton = new Button(Driver, new Locator("OkButton",
                By.XPath("//form[@id='productModel']/input[2]")));

            CancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//form[@id='productModel']/input[3]")));
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
