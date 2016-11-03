using System;
using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditProductTest : TestRunner
    {
        private String testProductName;
        private String testProductDescription;
        private String testProductPrice;

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(Roles.SUPERVISOR);

            itemManagementPage = userInfoPage.ClickItemManagementLink();

            editProductPage = itemManagementPage.ClickEditFirstProductLink();

            testProductName = editProductPage.ProductPriceInput
                .GetValue();
            testProductDescription = editProductPage.ProductDescriptionInput
                .GetValue();
            testProductPrice = editProductPage.ProductPriceInput
                .GetValue();
        }

        [TestMethod]
        public void TestEditProductAbility()
        {
            const String ProductNameForChange = "AnotherName";
            const String ProductDescriptionForChange = "AnotherDescription";
            const String ProductPriceForChange = "50.0";

            editProductPage.FillProductNameInput(ProductNameForChange)
                .FillProductDescriptionInput(ProductDescriptionForChange)
                .FillProductPriceInput(ProductPriceForChange)
                .ClickOkButton();

            itemManagementPage.FillSearchInput(testProductName)
                .ClickSearchButton();

            Assert.IsTrue(itemManagementPage.CountOfProductFound.GetText().Equals("0"),
                "Old Product still exists !");

            itemManagementPage.FillSearchInput(ProductNameForChange)
                .ClickSearchButton();

            Assert.AreEqual(itemManagementPage.FirstProductNameText.GetText(),
                ProductNameForChange, "Product Name (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductNameText.GetText(), ProductNameForChange);

            Assert.AreEqual(itemManagementPage.FirstProductDescriptionText.GetText(),
                ProductDescriptionForChange, "Product Description (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductDescriptionText.GetText(), ProductDescriptionForChange);

            Assert.AreEqual(itemManagementPage.FirstProductPriceText.GetText(),
                ProductPriceForChange, "Product Price (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductPriceText.GetText(), ProductPriceForChange);
        }

        [TestCleanup]
        public void TearDown()
        {
            itemManagementPage.ClickEditFirstProductLink();

            editProductPage.FillProductNameInput(testProductName)
                .FillProductDescriptionInput(testProductDescription)
                .FillProductPriceInput(testProductPrice)
                .ClickOkButton();
        }
    }

}
