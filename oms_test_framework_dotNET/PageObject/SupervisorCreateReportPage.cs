﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class SupervisorCreateReportPage : PageObject
    {
        // SaveReportLink is unique SupervisorCreateReportPage element
        [FindsBy(How = How.XPath, Using = "//div[@id='list']/a")]
        public IWebElement SaveReportLink { get; set; }

        public SupervisorCreateReportPage(IWebDriver driver) : base(driver)
        {

        }

        public SupervisorReportPage ClickSaveReportLink()
        {
            SaveReportLink.Click();
            return new SupervisorReportPage(Driver);
        }
    }
}
