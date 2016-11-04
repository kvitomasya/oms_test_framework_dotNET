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

            testProductName = editProductPage.productPriceInput
                .GetValue();
            testProductDescription = editProductPage.productDescriptionInput
                .GetValue();
            testProductPrice = editProductPage.productPriceInput
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

            Assert.IsTrue(itemManagementPage.countOfProductFound.GetText().Equals("0"),
                "Old Product still exists !");

            itemManagementPage.FillSearchInput(ProductNameForChange)
                .ClickSearchButton();

            Assert.AreEqual(itemManagementPage.firstProductNameText.GetText(),
                ProductNameForChange, "Product Name (actual={0}) should be changed to (expected={1})",
                itemManagementPage.firstProductNameText.GetText(), ProductNameForChange);

            Assert.AreEqual(itemManagementPage.firstProductDescriptionText.GetText(),
                ProductDescriptionForChange, "Product Description (actual={0}) should be changed to (expected={1})",
                itemManagementPage.firstProductDescriptionText.GetText(), ProductDescriptionForChange);

            Assert.AreEqual(itemManagementPage.firstProductPriceText.GetText(),
                ProductPriceForChange, "Product Price (actual={0}) should be changed to (expected={1})",
                itemManagementPage.firstProductPriceText.GetText(), ProductPriceForChange);
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
