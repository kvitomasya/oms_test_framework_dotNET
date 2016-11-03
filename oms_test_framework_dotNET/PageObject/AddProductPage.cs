using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Locators;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddProductPage : PageObject
    {
        internal Button OkButton;
        internal Button CancelButton;
        internal TextInputField ProductNameInput;
        internal TextInputField ProductDescriptionInput;
        internal TextInputField ProductPriceInput;
        internal Element ProductNameErrorText;
        internal Element ProductDescriptionErrorText;
        internal Element ProductPriceErrorText;

        public AddProductPage(IWebDriver driver) : base(driver)
        {
            // OkButton is unique identifier of AddProductPage
            OkButton = new Button(Driver, new Locator("OkButton",
                By.XPath("//form[@id='productModel']/input[2]")));

            CancelButton = new Button(Driver, new Locator("CancelButton",
                By.XPath("//form[@id='productModel']/input[3]")));

            ProductNameInput = new TextInputField(Driver,
                new Locator("ProductNameInput", By.Id("name")));

            ProductDescriptionInput = new TextInputField(Driver,
                new Locator("TextInputField", By.Id("description")));

            ProductPriceInput = new TextInputField(Driver,
                new Locator("ProducrPriceInput", By.Id("price")));

            ProductNameErrorText = new Element(Driver, new Locator("ProductNameErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[1]/td[3]")));

            ProductDescriptionErrorText = new Element(Driver, new Locator("ProductDescriptionErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[2]/td[3]")));

            ProductPriceErrorText = new Element(Driver, new Locator("ProductPriceErrorText",
                By.XPath("//form[@id='productModel']/table/tbody/tr[3]/td[3]")));
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

        public AddProductPage FillProductNameInput(String productName)
        {
            ProductNameInput.Clear();
            ProductNameInput.SendKeys(productName);
            return this;
        }

        public AddProductPage FillProductDescriptionInput(String productDescription)
        {
            ProductDescriptionInput.Clear();
            ProductDescriptionInput.SendKeys(productDescription);
            return this;
        }

        public AddProductPage FillProductPriceInput(String productPrice)
        {
            ProductPriceInput.Clear();
            ProductPriceInput.SendKeys(productPrice);
            return this;
        }
    }
}
