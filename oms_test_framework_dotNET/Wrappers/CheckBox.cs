using oms_test_framework_dotNET.Locators;
using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Wrappers
{
    class CheckBox : AbstractClicableElement<CheckBox>
    {
        public CheckBox(IWebDriver driver, Locator locator) : base(driver, locator)
        {
        }

        public void Select()
        {
            if (!Driver.FindElement(byLocator).Selected)
            {
                this.Click();
            }
        }

        public void Deselect()
        {
            if (Driver.FindElement(byLocator).Selected)
            {
                this.Click();
            }
        }

    }
}
