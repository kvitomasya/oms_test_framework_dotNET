using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Tests.Administrator
{
    [TestClass]
    public class UserSearchTest : TestRunner
    {

        const string DataDriver = "System.Data.OleDb";
        const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=${basedir}/../../../Resources/DataProvider/UserSearchTest.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

        [TestInitialize]
        public void SetUpTest()
        {
            userInfoPage = logInPage.LogInAs(Roles.ADMINISTRATOR);
            administrationPage = userInfoPage.ClickAdministrationLink();
        }


        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "AllColumnsFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithAllColumnsFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);

        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "FirstNameFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithFirstNameFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "LastNameFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithLastNameFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "LoginFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithLoginFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "RoleFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithRoleFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "RegionFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithRegionFilter()
        {
            String FirstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String SecondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String SearchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String ExpectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(FirstSearchFilter)
               .FillConditionFilter(SecondSearchFilter)
               .FillSearchInputField(SearchingValue)
               .ClickSearchButton();

            Assert.AreEqual(administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue,
                "The found user login: {0} is not the expected one: {1}",
                administrationPage.LogInFirstCellLink.GetText(), ExpectedFoundValue);
        }
    }
}
