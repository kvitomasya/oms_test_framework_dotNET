using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddProductPage : PageObject
    {
        internal Button okButton;
        internal Button cancelButton;
        internal TextInputField productNameInput;
        internal TextInputField productDescriptionInput;
        internal TextInputField productPriceInput;
        internal Element productNameErrorText;
        internal Element productDescriptionErrorText;
        internal Element productPriceErrorText;

        public AddProductPage(IWebDriver driver) : base(driver)
        {
            // OkButton is unique identifier of AddProductPage
            okButton = new Button(Driver, new Locator("OkButton",
                By.XPath("//form[@id='productModel']/input[2]")));

            cancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//form[@id='productModel']/input[3]")));

            productNameInput = new TextInputField(Driver,
                new Locator("ProductNameInput", By.Id("name")));

            productDescriptionInput = new TextInputField(Driver,
                new Locator("TextInputField", By.Id("description")));

            productPriceInput = new TextInputField(Driver,
                new Locator("ProducrPriceInput", By.Id("price")));

            productNameErrorText = new Element(Driver, new Locator("ProductNameErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[1]/td[3]")));

            productDescriptionErrorText = new Element(Driver, new Locator("ProductDescriptionErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[2]/td[3]")));

            productPriceErrorText = new Element(Driver, new Locator("ProductPriceErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[3]/td[3]")));
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

        public AddProductPage FillProductNameInput(String productName)
        {
            productNameInput.Clear();
            productNameInput.SendKeys(productName);
            return this;
        }

        public AddProductPage FillProductDescriptionInput(String productDescription)
        {
            productDescriptionInput.Clear();
            productDescriptionInput.SendKeys(productDescription);
            return this;
        }

        public AddProductPage FillProductPriceInput(String productPrice)
        {
            productPriceInput.Clear();
            productPriceInput.SendKeys(productPrice);
            return this;
        }
    }
}
