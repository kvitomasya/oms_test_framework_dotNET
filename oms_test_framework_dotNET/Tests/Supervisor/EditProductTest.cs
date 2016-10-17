using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace oms_test_framework_dotNET.Tests
{
    [TestClass]
    public class EditProductTest : TestRunner
    {

        private const String SupervisorLogin = "login2";
        private const String SupervisorPassword = "qwerty";

        private String testProductName;
        private String testProductDescription;
        private String testProductPrice;

        [TestInitialize]
        public void SetUp()
        {
            userInfoPage = logInPage.LogInAs(SupervisorLogin, SupervisorPassword);

            itemManagementPage = userInfoPage.ClickItemManagementLink();

            editProductPage = itemManagementPage.ClickEditFirstProductLink();

            testProductName = editProductPage.ProductPriceInput
                .GetAttribute("value");
            testProductDescription = editProductPage.ProductDescriptionInput
                .GetAttribute("value");
            testProductPrice = editProductPage.ProductPriceInput
                .GetAttribute("value");
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

            Assert.IsTrue(itemManagementPage.CountOfProductFound.Text.Equals("0"),
                "Old Product still exists !");

            itemManagementPage.FillSearchInput(ProductNameForChange)
                .ClickSearchButton();

            Assert.AreEqual(itemManagementPage.FirstProductNameText.Text,
                ProductNameForChange, "Product Name (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductNameText.Text, ProductNameForChange);

            Assert.AreEqual(itemManagementPage.FirstProductDescriptionText.Text,
                ProductDescriptionForChange, "Product Description (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductDescriptionText.Text, ProductDescriptionForChange);

            Assert.AreEqual(itemManagementPage.FirstProductPriceText.Text,
                ProductPriceForChange, "Product Price (actual={0}) should be changed to (expected={1})",
                itemManagementPage.FirstProductPriceText.Text, ProductPriceForChange);
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
