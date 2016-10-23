using NHibernate;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Utils;
using System;

namespace oms_test_framework_dotNET.DBHelpers
{
    public sealed class DBOrderHandler
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE Orders AUTO_INCREMENT=0;";

        private DBOrderHandler()
        {

        }

        public static int CreateOrder(Order order)
        {
            object id = null;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    id = session.Save(order);
                    transaction.Commit();
                }
            }
            return int.Parse(id.ToString());
        }

        public static void DeleteOrderById(int orderId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                try
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(session.Get<Order>(orderId));
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

        public static void DeleteOrderByNumber(int orderNumber)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(session.CreateCriteria(typeof(Order))
                        .Add(NHibernate.Criterion.Restrictions.Eq("OrderNumber", orderNumber))
                        .UniqueResult<Order>());

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

        public static Order GetOrderById(int orderId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Order>(orderId);
            }
        }

        public static Order GetOrderByNumber(int orderNumber)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.CreateCriteria(typeof(Order))
                    .Add(NHibernate.Criterion.Restrictions.Eq("OrderNumber", orderNumber))
                    .UniqueResult<Order>();
            }
        }
    }
}
