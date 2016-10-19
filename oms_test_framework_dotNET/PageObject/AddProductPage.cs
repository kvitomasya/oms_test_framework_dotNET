using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddProductPage : PageObject
    {
        // OkButton is unique identifier of AddProductPage
        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/input[2]")]
        public IWebElement OkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/input[3]")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ProductNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "description")]
        public IWebElement ProductDescriptionInput { get; set; }

        [FindsBy(How = How.Id, Using = "price")]
        public IWebElement ProductPriceInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/table/tbody/tr[1]/td[3]")]
        public IWebElement ProductNameErrorText { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/table/tbody/tr[2]/td[3]")]
        public IWebElement ProductDescriptionErrorText { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/table/tbody/tr[3]/td[3]")]
        public IWebElement ProductPriceErrorText { get; set; }

        public AddProductPage(IWebDriver driver) : base(driver)
        {

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
