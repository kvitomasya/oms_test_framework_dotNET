using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Utils;
using oms_test_framework_dotNET.Wrappers;
using OpenQA.Selenium.Support.UI;
using System;
using static oms_test_framework_dotNET.Utils.LoggerNLog;

namespace oms_test_framework_dotNET.Asserts
{
    internal class AbstractElementAssert
    {
        private AbstractElement actual;

        private AbstractElementAssert(AbstractElement actual)
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
                LogFail(String.Format("Element {0} should be displayed!",
                    actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should be displayed!",
                    actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} displayed!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsNotDisplayed()
        {
            isNotNull();
            if (actual.IsDisplayed())
            {
                LogFail(String.Format("Element {0} should not be displayed!",
                    actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should not be displayed!",
                    actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} is not displayed!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert TextContains(string condition)
        {
            isNotNull();
            if (!actual.GetText().Contains(condition))
            {
                LogFail(String.Format("Text from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Text from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Text from element {0} contains {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert TextEquals(string condition)
        {
            isNotNull();
            if (!actual.GetText().Equals(condition))
            {
                LogFail(String.Format("Text from element\" {0} \"should be equal to {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Text from element\" {0} \"should be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Text from element\" {0} \"equals {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert TextNotEquals(string condition)
        {
            isNotNull();
            if (actual.GetText().Equals(condition))
            {
                LogFail(String.Format("Text from element {0} should not be equal to {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Text from element {0} should not be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Text from element {0} is not equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueContains(string condition)
        {
            isNotNull();
            if (!actual.GetValue().Contains(condition))
            {
                LogFail(String.Format("Value from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Value from element {0} should contain {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Value from element {0} contains {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueEquals(string condition)
        {
            isNotNull();
            if (!actual.GetValue().Equals(condition))
            {
                LogFail(String.Format("Value from element {0} should be equals to {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Value from element {0} should be equals to {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Value from element {0} equals {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert ValueNotEqual(string condition)
        {
            isNotNull();
            if (actual.GetValue().Equals(condition))
            {
                LogFail(String.Format("Value from element {0} should be equal to {1} !",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Value from element {0} should be equal to {1} !",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Value from element {0} equals {1} !",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert IsValueEmpty()
        {
            isNotNull();
            if (!string.IsNullOrWhiteSpace(actual.GetValue()))
            {
                LogFail(String.Format("Value from element {0} should be empty!",
                    actual.GetLocatorName()));
                Assert.Fail(String.Format("Value from element {0} should be empty!",
                    actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Value from element {0} is empty!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsValueNotEmpty()
        {
            isNotNull();
            if (string.IsNullOrWhiteSpace(actual.GetValue()))
            {
                LogFail(String.Format("Value from element {0} should not be empty!",
                    actual.GetLocatorName()));
                Assert.Fail(String.Format("Value from element {0} should not be empty!",
                    actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Value from element {0} is not empty!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsTextBold()
        {
            isNotNull();
            if (!"700".Equals(actual.GetCssValue("font-weight")))
            {
                LogFail(String.Format("Element {0} should be Bold!", actual));
                Assert.Fail(String.Format("Element {0} should be Bold!", actual));
            }
            else
            {
                LogPass(String.Format("Element {0} is Bold!", actual));
            }
            return this;
        }

        public AbstractElementAssert IsTextEmpty()
        {
            isNotNull();
            if (!string.IsNullOrWhiteSpace(actual.GetText()))
            {
                LogFail(String.Format("Element {0} should not have a text!",
                    actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should not have a text!",
                    actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} does not contain any text!",
                    actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsTextNotEmpty()
        {
            isNotNull();
            if (string.IsNullOrWhiteSpace(actual.GetText()))
            {
                LogFail(String.Format("Element {0} should have a text!", actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should have a text!", actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} contains text!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsEnabled()
        {
            isNotNull();
            if (!actual.IsEnabled())
            {
                LogFail(String.Format("Element {0} should be Enabled!", actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should be Enabled!", actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} is Enabled!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert IsDisabled()
        {
            isNotNull();
            if (actual.IsEnabled())
            {
                LogFail(String.Format("Element {0} should be disabled!", actual.GetLocatorName()));
                Assert.Fail(String.Format("Element {0} should be disabled!", actual.GetLocatorName()));
            }
            else
            {
                LogPass(String.Format("Element {0} is disabled!", actual.GetLocatorName()));
            }
            return this;
        }

        public AbstractElementAssert SelectedOptionEquals(string condition)
        {
            isNotNull();
            if (!condition.Equals(new SelectElement(actual.GetElement()).SelectedOption.Text))
            {
                LogFail(String.Format("Value from element {0} should be equal to {1}!",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Value from element {0} should be equal to {1}!",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Value from element {0} equals {1}!",
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
                LogFail(String.Format("Value from element {0} should be equal to {1} (Case Ignored)!",
                    actual.GetLocatorName(), condition));
                Assert.Fail(String.Format("Value from element {0} should be equal to {1} (Case Ignored)!",
                    actual.GetLocatorName(), condition));
            }
            else
            {
                LogPass(String.Format("Value from element {0} equals to {1} (Case Ignored)!",
                    actual.GetLocatorName(), condition));
            }
            return this;
        }

        public AbstractElementAssert isNotNull()
        {
            if (actual == null)
            {
                LogFail("Element should not be null");
                Assert.Fail("Element should not be null");
            }
            return this;
        }
    }
}


