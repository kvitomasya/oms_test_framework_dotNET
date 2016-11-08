using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Wrappers;

namespace oms_test_framework_dotNET.Asserts
{
    internal class FluentAssert
    {
        internal static AbstractElementAssert AssertThat(AbstractElement actual)
        {
            return AbstractElementAssert.AssertThat(actual);
        }

        internal static OrderAssert AssertThat(Order actual)
        {
            return OrderAssert.AssertThat(actual);
        }
    }
}
