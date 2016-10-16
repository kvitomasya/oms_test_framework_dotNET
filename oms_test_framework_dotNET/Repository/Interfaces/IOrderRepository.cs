using oms_test_framework_dotNET.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);

        Order GetOrderByNumber(int orderNumber);

        int CreateOrder(Order order);

        void DeleteOrderById(int orderId);

        void DeleteOrderByNumber(int orderNumber);
    }
}
