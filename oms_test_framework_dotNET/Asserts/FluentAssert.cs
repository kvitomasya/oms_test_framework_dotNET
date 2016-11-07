using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Domains;

namespace oms_test_framework_dotNET.Asserts
{
    internal class FluentAsserts
    {
       internal static AbstractElementAssert AssertThat(AbstractElement actual)
        {
            return new AbstractElementAssert(actual);
        }

       internal static OrderAssert AssertThat(Order actual)
        {
            return new OrderAssert(actual);
        }
    }
}
