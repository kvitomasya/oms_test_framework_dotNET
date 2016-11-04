using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class EditProductPage : PageObject
    {
        internal TextInputField productNameInput;
        internal TextInputField productDescriptionInput;
        internal TextInputField productPriceInput;
        internal Button okButton;
        internal Button cancelButton;

        public EditProductPage(IWebDriver driver) : base(driver)
        {
            productNameInput = new TextInputField(Driver, new Locator("ProductNameInput",
                By.Id("name")));

            productDescriptionInput = new TextInputField(Driver, new Locator("ProductDescriptionInput",
                By.Id("description")));

            productPriceInput = new TextInputField(Driver, new Locator("ProductPriceInput",
                By.Id("price")));

            okButton = new Button(Driver, new Locator("OkButton",
                By.XPath("//form[@id='productModel']/input[2]")));

            cancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//form[@id='productModel']/input[3]")));
        }

        public EditProductPage FillProductNameInput(String productName)
        {
            productNameInput.Clear();
            productNameInput.SendKeys(productName);
            return this;
        }

        public EditProductPage FillProductDescriptionInput(String productDescription)
        {
            productDescriptionInput.Clear();
            productDescriptionInput.SendKeys(productDescription);
            return this;
        }

        public EditProductPage FillProductPriceInput(String productPrice)
        {
            productPriceInput.Clear();
            productPriceInput.SendKeys(productPrice);
            return this;
        }

        public ItemManagementPage ClickOkButton()
        {
            okButton.Click();
            return new ItemManagementPage(Driver);
        }

        public ItemManagementPage ClickCancelButton()
        {
            cancelButton.Click();
            return new ItemManagementPage(Driver);
        }
    }
}
