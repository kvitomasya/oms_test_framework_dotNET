using oms_test_framework_dotNET.Utils;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.DBHelpers;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

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

            AssertThat(itemManagementPage.firstProductNameText)
                .TextEquals(ValidProductName);

            AssertThat(itemManagementPage.firstProductDescriptionText)
                .TextEquals(ValidProductDescription);

            AssertThat(itemManagementPage.firstProductPriceText)
                .TextEquals(ValidProductPrice);

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

            AssertThat(itemManagementPage.countOfProductFound).TextEquals("0");
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

            AssertThat(addProductPage.productNameErrorText).TextEquals("Please enter product name!");

            AssertThat(addProductPage.productDescriptionErrorText).TextEquals("");

            AssertThat(addProductPage.productPriceErrorText).TextEquals("Please enter product price!");

            addProductPage.FillProductNameInput(InvalidShortName)
                    .FillProductDescriptionInput(InvalidDescription)
                    .FillProductPriceInput(InvalidPrice)
                    .ClickOkButton();

            AssertThat(addProductPage.productNameErrorText).TextEquals("Enter value in range: 3-13");

            AssertThat(addProductPage.productDescriptionErrorText).TextEquals("Enter less then 25 letters");

            AssertThat(addProductPage.productPriceErrorText).TextEquals("Please enter double value!");

            addProductPage.FillProductNameInput(InvalidLongName)
                    .FillProductDescriptionInput(InvalidDescription)
                    .FillProductPriceInput(InvalidPrice)
                    .ClickOkButton();

            AssertThat(addProductPage.productNameErrorText).TextEquals("Enter value in range: 3-13");

            AssertThat(addProductPage.productDescriptionErrorText).TextEquals("Enter less then 25 letters");

            AssertThat(addProductPage.productPriceErrorText).TextEquals("Please enter double value!");
        }

    }
}
