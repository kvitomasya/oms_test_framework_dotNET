using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace oms_test_framework_dotNET.PageObject
{
    public class AddProductPage : PageObject
    {
        // OkButton is unique identifier of AddProductPage
        [FindsBy(How = How.XPath, Using = "//form[@id='productModel']/input[2]")]
        public IWebElement OkButton { get; set; }

        public AddProductPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
