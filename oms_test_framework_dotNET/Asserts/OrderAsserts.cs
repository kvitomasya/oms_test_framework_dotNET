using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using oms_test_framework_dotNET.Domains;

namespace oms_test_framework_dotNET.Asserts
{
    internal class OrderAssert
    {
        private Order actual;

        internal OrderAssert(Order actual)
        {
            this.actual = actual;
        }

        public static OrderAssert AssertThat(Order actual)
        {
            return new OrderAssert(actual);
        }

        public void IsNull()
        {
            if(!(actual == null))
            {
                Assert.Fail(String.Format("Required order should be null !"));
            }
        }

        public void AreEqual(Order condition)
        {
            if (!(actual.OrderNumber == condition.OrderNumber))
            {
                Assert.Fail(String.Format("Required order should be !"));
            }
        }

    }
}
