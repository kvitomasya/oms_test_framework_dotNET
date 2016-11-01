using oms_test_framework_dotNET.Utils;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;

namespace oms_test_framework_dotNET.Tests.Supervisor
{
    [TestClass]
    public class AddNewProductTest : TestRunner
    {
        private const String ValidProductName = "UniqueName";
        private const String ValidProductDescription = "testProductDescription";
        private const String ValidProductPrice = "10.0";

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);
            itemManagementPage = userInfoPage.ClickItemManagementLink();
            addProductPage = itemManagementPage.ClickAddProductLink();
        }

        [TestMethod]
        public void TestAddValidProduct()
        {
            addProductPage.FillProductNameInput(ValidProductName)
                .FillProductDescriptionInput(ValidProductDescription)
                .FillProductPriceInput(ValidProductPrice)
                .ClickOkButton();

            Product testProduct = DBProductHandler.GetLastProduct();

            itemManagementPage.FillSearchInput(ValidProductName)
                .ClickSearchButton();

            Assert.AreEqual(itemManagementPage.FirstProductNameText.GetText(),
                ValidProductName, "Product name {0} does not equal to created one {1}",
                itemManagementPage.FirstProductNameText.GetText(), ValidProductName);

            Assert.AreEqual(itemManagementPage.FirstProductDescriptionText.GetText(),
                ValidProductDescription, "Product description {0} does not equal to created one {1}",
                itemManagementPage.FirstProductDescriptionText.GetText(), ValidProductDescription);

            Assert.AreEqual(itemManagementPage.FirstProductPriceText.GetText(),
                ValidProductPrice, "Product price {0} does not equal to created one {1}",
                itemManagementPage.FirstProductPriceText.GetText(), ValidProductPrice);

            DBProductHandler.DeleteProduct(testProduct.Id);
        }

        [TestMethod]
        public void TestCancelAddProduct()
        {
            addProductPage.FillProductNameInput(ValidProductName)
                .FillProductDescriptionInput(ValidProductDescription)
                .FillProductPriceInput(ValidProductPrice)
                .ClickCancelButton();

            itemManagementPage.FillSearchInput(ValidProductName)
               .ClickSearchButton();

            Assert.AreEqual(itemManagementPage.CountOfProductFound.GetText(), "0",
                "Product has been unexpectely created !");
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            const String InvalidShortName = "FU";
            const String InvalidLongName = "TestProductName";
            const String InvalidDescription = "InvalidProductDescriptionTest";
            const String InvalidPrice = "12345678901234";

            addProductPage.FillProductNameInput("")
                    .FillProductDescriptionInput("")
                    .FillProductPriceInput("")
                    .ClickOkButton();

            Assert.AreEqual(addProductPage.ProductNameErrorText.GetText(),
                "Please enter product name!", "Error message is not appeared or is incorrect !");
            Assert.IsTrue(addProductPage.ProductDescriptionErrorText.GetText() == "",
                "Unexpected error message !");
            Assert.AreEqual(addProductPage.ProductPriceErrorText.GetText(),
                "Please enter product price!", "Error message is not appeared or is incorrect !");

            addProductPage.FillProductNameInput(InvalidShortName)
                    .FillProductDescriptionInput(InvalidDescription)
                    .FillProductPriceInput(InvalidPrice)
                    .ClickOkButton();

            Assert.AreEqual(addProductPage.ProductNameErrorText.GetText(),
                "Enter value in range: 3-13", "Error message is not appeared or is incorrect !");
            Assert.AreEqual(addProductPage.ProductDescriptionErrorText.GetText(),
                "Enter less then 25 letters", "Error message is not appeared or is incorrect !");
            Assert.AreEqual(addProductPage.ProductPriceErrorText.GetText(),
                "Please enter double value!", "Error message is not appeared or is incorrect !");

            addProductPage.FillProductNameInput(InvalidLongName)
                    .FillProductDescriptionInput(InvalidDescription)
                    .FillProductPriceInput(InvalidPrice)
                    .ClickOkButton();

            Assert.AreEqual(addProductPage.ProductNameErrorText.GetText(),
                "Enter value in range: 3-13", "Error message is not appeared or is incorrect !");
            Assert.AreEqual(addProductPage.ProductDescriptionErrorText.GetText(),
                "Enter less then 25 letters", "Error message is not appeared or is incorrect !");
            Assert.AreEqual(addProductPage.ProductPriceErrorText.GetText(),
                "Please enter double value!", "Error message is not appeared or is incorrect !");
        }

    }
}
