using NHibernate;
using NHibernate.Criterion;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Utils;
using System;
using System.Collections.Generic;

namespace oms_test_framework_dotNET.DBHelpers
{
    public sealed class DBOrderItemHandler
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE OrderItems AUTO_INCREMENT=0;";

        private DBOrderItemHandler()
        {

        }

        public static int CreateOrderItem(OrderItem orderItem)
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

        public static void DeleteOrderItemById(int orderItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(session.Get<OrderItem>(orderItemId));
                        transaction.Commit();
                    }
                }
                catch (Exception) { }

                finally
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.CreateSQLQuery(ResetAutoIncrementQuery)
                            .ExecuteUpdate();
                        transaction.Commit();
                    }
                }
            }
        }

        public static void DeleteOrderItemByOrderRef(int orderRef)
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

        public static OrderItem GetOrderItemById(int orderItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<OrderItem>(orderItemId);
            }
        }
    }
}
