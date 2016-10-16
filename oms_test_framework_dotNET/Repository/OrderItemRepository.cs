using oms_test_framework_dotNET.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oms_test_framework_dotNET.Domains;
using NHibernate;
using oms_test_framework_dotNET.Utils;
using NHibernate.Criterion;

namespace oms_test_framework_dotNET.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE OrderItems AUTO_INCREMENT=0;";

        public int CreateOrderItem(OrderItem orderItem)
        {
            object id = null;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    id = session.Save(orderItem);
                    transaction.Commit();
                }
            }
            return int.Parse(id.ToString());
        }

        public void DeleteOrderItemById(int orderItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(session.Get<OrderItem>(orderItemId));
                    transaction.Commit();
                }

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.CreateSQLQuery(ResetAutoIncrementQuery)
                        .ExecuteUpdate();
                    transaction.Commit();
                }
            }
        }

        public void DeleteOrderItemByOrderRef(int orderRef)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<OrderItem> items = session.CreateCriteria(typeof(OrderItem))
                        .Add(Restrictions.Eq("OrderRef", orderRef))
                        .List<OrderItem>();

                    foreach (OrderItem item in items)
                    {
                        session.Delete(item);
                    }

                    transaction.Commit();
                }

                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.CreateSQLQuery(ResetAutoIncrementQuery)
                        .ExecuteUpdate();
                    transaction.Commit();
                }
            }
        }

        public OrderItem GetOrderItemById(int orderItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<OrderItem>(orderItemId);
            }
        }
    }
}
