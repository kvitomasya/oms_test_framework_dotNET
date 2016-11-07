using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using oms_test_framework_dotNET.Domains;

namespace oms_test_framework_dotNET.Asserts
{
    internal class OrderAsserts
    {
        private Order actual;

        internal OrderAsserts(Order actual)
        {
            this.actual = actual;
        }

        public static OrderAsserts AssertThat(Order actual)
        {
            return new OrderAsserts(actual);
        }

        public void IsNull()
        {
            if(!(actual == null))
            {
                Assert.Fail(String.Format("Required order should be null !"));
            }
        }

        public void AreEquals(Order condition)
        {
            if (!(actual.OrderNumber == condition.OrderNumber))
            {
                Assert.Fail(String.Format("Required order should be !"));
            }
        }

    }
}
