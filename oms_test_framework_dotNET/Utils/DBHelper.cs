using oms_test_framework_dotNET.DBHelpers;
using oms_test_framework_dotNET.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Utils
{
    public class DBHelper
    {
        public static int createValidOrderInDB()
        {
            return DBOrderHandler.CreateOrder(Order.NewBuilder()
                .SetId(0)
                .SetDeliveryDate(null)
                .SetIsGift(0)
                .SetMaxDiscount(0)
                .SetOrderDate("2016-11-15 23:25:00")
                .SetOrderName("TestOrder")
                .SetOrderNumber(7)
                .SetPreferableDeliveryDate("2016-11-14 19:10:00")
                .SetTotalPrice(7500.0)
                .SetAssignee(8)
                .SetCustomer(10)
                .SetOrderStatusReference(1)
                .Build());
        }

        public static int createOrderItemInDB()
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
