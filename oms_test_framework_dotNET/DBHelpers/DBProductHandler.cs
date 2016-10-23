using NHibernate;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Utils;
using System;

namespace oms_test_framework_dotNET.DBHelpers
{
    public sealed class DBProductHandler
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE Products AUTO_INCREMENT=0;";

        private DBProductHandler()
        {

        }

        public static int CreateProduct(Product product)
        {
            object id = null;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    id = session.Save(product);
                    transaction.Commit();
                }
            }
            return int.Parse(id.ToString());
        }

        public static void DeleteProduct(int productId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(session.Get<Product>(productId));
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

        public static Product GetProductById(int productId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Product>(productId);
            }
        }

        public static Product GetLastProduct()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.CreateQuery("FROM Product ORDER BY Id DESC")
                    .SetMaxResults(1)
                    .UniqueResult<Product>();
            }
        }
    }
}
