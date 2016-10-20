using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Domains;

namespace oms_test_framework_dotNET.Utils
{
    public class TestHelper
    {
        private TestHelper()
        {
        }

        //  Quantity of Orders must be "<=6"
        public static int CreateValidOrderInDB()
        {
            return DBOrderHandler.CreateOrder(Order.NewBuilder()
                .SetId(0)
                .SetDeliveryDate(null)
                .SetIsGift(0)
                .SetMaxDiscount(0)
                .SetOrderDate("2016-11-15 23:25:00")
                .SetOrderName("NewOrderName")
                .SetOrderNumber(7)
                .SetPreferableDeliveryDate("2016-11-14 19:10:00")
                .SetTotalPrice(7500.0)
                .SetAssignee(8)
                .SetCustomer(10)
                .SetOrderStatusReference(1)
                .Build());
        }

        public static int CreateOrderItemInDB()
        {
            return DBOrderItemHandler.CreateOrderItem(OrderItem.NewBuilder()
                .SetId(0)
                .SetCost(7500.0)
                .SetItemPrice(500.0)
                .SetQuantity(3)
                .SetDimensionReference(2)
                .SetOrderReference(7)
                .SetProductReference(6)
                .Build());
        }
    }
}
