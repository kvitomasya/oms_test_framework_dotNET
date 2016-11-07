using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Enums;
using static oms_test_framework_dotNET.Asserts.FluentAsserts;

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
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);              
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "FirstNameFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithFirstNameFilter()
        {
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "LastNameFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithLastNameFilter()
        {
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "LoginFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithLoginFilter()
        {
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "RoleFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithRoleFilter()
        {
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);
        }

        [TestMethod]
        [DataSource(DataDriver, ConnectionString, "RegionFilter$", DataAccessMethod.Sequential)]

        public void TestUserSearchWithRegionFilter()
        {
            String firstSearchFilter = TestContext.DataRow["FirstSearchFilter"].ToString();
            String secondSearchFilter = TestContext.DataRow["SecondSearchFilter"].ToString();
            String searchingValue = TestContext.DataRow["SearchingValue"].ToString();
            String expectedFoundValue = TestContext.DataRow["ExpectedFoundValue"].ToString();

            administrationPage.FillFieldFilter(firstSearchFilter)
               .FillConditionFilter(secondSearchFilter)
               .FillSearchInputField(searchingValue)
               .ClickSearchButton();

            AssertThat(administrationPage.logInFirstCellLink).TextEquals(expectedFoundValue);
        }
    }
}
