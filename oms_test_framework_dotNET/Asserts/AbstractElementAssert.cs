using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Support.UI;
using oms_test_framework_dotNET.Wrappers;

namespace oms_test_framework_dotNET.Asserts
{
    internal class AbstractElementAssert
    {
        private AbstractElement actual;

       internal AbstractElementAssert(AbstractElement actual)
        {
            this.actual = actual;
        }

        public static AbstractElementAssert AssertThat(AbstractElement actual)
        {
            return new AbstractElementAssert(actual);
        }

        public AbstractElementAssert IsDisplayed()
        {
            isNotNull();
            if (!actual.IsDisplayed())
            {
                Assert.Fail(String.Format("Element {0} should be displayed!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsNotDisplayed()
        {
            isNotNull();
            if (actual.IsDisplayed())
            {
                Assert.Fail(String.Format("Element {0} should not be displayed!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert TextContains(string condition)
        {
            isNotNull();
            if (!actual.GetText().Contains(condition))
            {
                Assert.Fail(String.Format("Text from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert TextEquals(string condition)
        {
            isNotNull();
            if (!actual.GetText().Equals(condition))
            {
                Assert.Fail(String.Format("Text from element\" {0} \"should be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert TextNotEquals(string condition)
        {
            isNotNull();
            if (actual.GetText().Equals(condition))
            {
                Assert.Fail(String.Format("Text from element {0} should not be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueContains(string condition)
        {
            isNotNull();
            if (!actual.GetValue().Contains(condition))
            {
                Assert.Fail(String.Format("Value from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueEquals(string condition)
        {
            isNotNull();
            if (!actual.GetValue().Equals(condition))
            {
                Assert.Fail(String.Format("Value from element {0} should be equals to {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueNotEqual(string condition)
        {
            isNotNull();
            if (actual.GetValue().Equals(condition))
            {
                Assert.Fail(String.Format("Value from element {0} should be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert IsValueEmpty()
        {
            isNotNull();
            if (!string.IsNullOrWhiteSpace(actual.GetValue()))
            {
                Assert.Fail(String.Format("Value from element {0} should be empty!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsValueNotEmpty()
        {
            isNotNull();
            if (string.IsNullOrWhiteSpace(actual.GetValue()))
            {
                Assert.Fail(String.Format("Value from element {0} should not be empty!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsTextBold()
        {
            isNotNull();
            if (!"700".Equals(actual.GetCssValue("font-weight")))
            {
                Assert.Fail(String.Format("Element {0} should be Bold!", actual));
            }
            return this;
        }

        public AbstractElementAssert IsTextEmpty()
        {
            isNotNull();
            if (!string.IsNullOrWhiteSpace(actual.GetText()))
            {
                Assert.Fail(String.Format("Element {0} should not have a text!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsTextNotEmpty()
        {
            isNotNull();
            if (string.IsNullOrWhiteSpace(actual.GetText()))
            {
                Assert.Fail(String.Format("Element {0} should have a text!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsEnabled()
        {
            isNotNull();
            if (!actual.IsEnabled())
            {
                Assert.Fail(String.Format("Element {0} should be Enabled!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsDisabled()
        {
            isNotNull();
            if (actual.IsEnabled())
            {
                Assert.Fail(String.Format("Element {0} should be disabled!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert SelectedOptionEquals(string condition)
        {
            isNotNull();
            if (!condition.Equals(new SelectElement(actual.GetElement()).SelectedOption.Text))
            {
                Assert.Fail(String.Format("Value from element {0} should be equal to {1}!",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert SelectedOptionEqualsIgnorCase(string condition)
        {
            isNotNull();
            if (!condition.Equals(new SelectElement(actual.GetElement()).SelectedOption.Text,
                StringComparison.CurrentCultureIgnoreCase))
            {
                Assert.Fail(String.Format("Value from element {0} should be equal Ignoring Case to {1}!",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert isNotNull()
        {
            if (actual == null)
            {
                Assert.Fail("Element should not be null");
            }
            return this;
        }
    }
}


