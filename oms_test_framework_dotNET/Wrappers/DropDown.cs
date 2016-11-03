using System;
using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace oms_test_framework_dotNET.Wrappers
{
    class DropDown : AbstractClicableElement<DropDown>
    {
        public DropDown(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public DropDown SelectByIndex(int indexOfElement)
        {
            new SelectElement(Driver.FindElement(ByLocator)).SelectByIndex(indexOfElement);
            return this;
        }

        public DropDown SelectByValue(String valueOfElement)
        {
            new SelectElement(Driver.FindElement(ByLocator)).SelectByValue(valueOfElement);
            return this;
        }

        public DropDown DeselectByIndex(int indexOfElement)
        {
            new SelectElement(Driver.FindElement(ByLocator)).DeselectByIndex(indexOfElement);
            return this;
        }

        public DropDown DeselectByValue(String valueOfElement)
        {
            new SelectElement(Driver.FindElement(ByLocator)).DeselectByValue(valueOfElement);
            return this;
        }

        public void SendKeys(String inputText)
        {
            Driver.FindElement(ByLocator).SendKeys(inputText);
        }

        public IWebElement GetFirstSelectedOption()
        {
            return new SelectElement(Driver.FindElement(ByLocator)).SelectedOption;
        }

    }

}
