﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class UserInfoPage : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/descendant::a[@href='itemManagement.htm']")]
        public IWebElement ItemManagementLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[2]/a")]
        public static IWebElement UserInfoLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[1]/a")]
        public IWebElement CustomerOrderingLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[1]/a")]
        public IWebElement AdministrationLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='nav']/li[1]/a")]
        public IWebElement MerchandiserOrderingLink { get; set; }

        // UserInfoFieldSet is unique element on UserInfoPage
        [FindsBy(How = How.XPath, Using = "//div[@id='content']//legend")]
        public IWebElement UserInfoFieldSet { get; set; }

        public UserInfoPage(IWebDriver driver) : base(driver)
        {
        }

        public ItemManagementPage ClickItemManagementLink()
        {
            ItemManagementLink.Click();
            return new ItemManagementPage(Driver);
        }

        public CustomerOrderingPage ClickCustomerOrdetingLink()
        {
            CustomerOrderingLink.Click();
            return new CustomerOrderingPage(Driver);
        }

        public AdministrationPage ClickAdministrationLink()
        {
            AdministrationLink.Click();
            return new AdministrationPage(Driver);
        }

        public MerchandiserOrderingPage ClickMerchandiserOrderingLink()
        {
            MerchandiserOrderingLink.Click();
            return new MerchandiserOrderingPage(Driver);
        }
    }
}