using oms_test_framework_dotNET.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Repository.Interfaces
{
    public interface IOrderItemRepository
    {
        int CreateOrderItem(OrderItem orderItem);

        OrderItem GetOrderItemById(int orderItemId);

        void DeleteOrderItemById(int orderItemId);

        void DeleteOrderItemByOrderRef(int orderRef);
    }
}
