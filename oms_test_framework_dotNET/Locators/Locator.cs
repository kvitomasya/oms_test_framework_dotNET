using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Locators
{
    class Locator
    {
        private string name;
        private By locatorValue;

       public Locator(string name, By locatorValue)
        {
            this.name = name;
            this.locatorValue = locatorValue;
        }
        internal By GetLocatorValue()
        {
            return locatorValue;
        }

        internal string GetName()
        {
            return name;
        }
    }
}
