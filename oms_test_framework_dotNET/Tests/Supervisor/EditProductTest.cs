using System;
using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAssert;

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

            AssertThat(itemManagementPage.countOfProductFound).TextEquals("0");

            itemManagementPage.FillSearchInput(ProductNameForChange)
                .ClickSearchButton();

            AssertThat(itemManagementPage.firstProductNameText).TextEquals(ProductNameForChange);

            AssertThat(itemManagementPage.firstProductDescriptionText).TextEquals(ProductDescriptionForChange);

            AssertThat(itemManagementPage.firstProductPriceText).TextEquals(ProductPriceForChange);
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
