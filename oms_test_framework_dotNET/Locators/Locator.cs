using OpenQA.Selenium;

namespace oms_test_framework_dotNET.Locators
{
    class Locator
    {
        public string name { get; set; }
        public By locator { get; set; }

       public Locator(string name, By locator)
        {
            this.name = name;
            this.locator = locator;
        }
    }
}
