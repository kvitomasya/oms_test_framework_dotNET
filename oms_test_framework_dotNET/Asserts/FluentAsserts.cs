using oms_test_framework_dotNET.Wrappers;
using oms_test_framework_dotNET.Domains;

namespace oms_test_framework_dotNET.Asserts
{
    internal class FluentAsserts
    {
       internal static AbstractElementAsserts AssertThat(AbstractElement actual)
        {
            return new AbstractElementAsserts(actual);
        }

       internal static OrderAsserts AssertThat(Order actual)
        {
            return new OrderAsserts(actual);
        }
    }
}
