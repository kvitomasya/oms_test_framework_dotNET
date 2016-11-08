using Microsoft.VisualStudio.TestTools.UnitTesting;
using oms_test_framework_dotNET.Domains;
using System;
using static oms_test_framework_dotNET.Utils.LoggerNLog;

namespace oms_test_framework_dotNET.Asserts
{
    internal class OrderAssert
    {
        private Order actual;

        private OrderAssert(Order actual)
        {
            this.actual = actual;
        }

        public static OrderAssert AssertThat(Order actual)
        {
            return new OrderAssert(actual);
        }

        public void IsNull()
        {
            if (!(actual == null))
            {
                LogFail(String.Format("Required order should be null !"));
                Assert.Fail(String.Format("Required order should be null !"));
            }
            else
            {
                LogPass(String.Format("Required order is null !"));
            }
        }

        public void AreEqual(Order condition)
        {
            if (!(actual.OrderNumber == condition.OrderNumber))
            {
                LogFail(String.Format("Required order should be !"));
                Assert.Fail(String.Format("Required order should be !"));
            }
            else
            {
                LogPass(String.Format("Required order is present !"));
            }
        }

    }
}
