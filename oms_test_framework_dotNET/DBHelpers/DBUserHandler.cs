using NHibernate;
using NHibernate.Criterion;
using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Enums;
using oms_test_framework_dotNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.DBHelpers
{
    public sealed class DBUserHandler
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE Users AUTO_INCREMENT=0;";

        private DBUserHandler()
        {

        }

        public static int CreateUser(User user)
        {
            object id = null;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    id = session.Save(user);
                    transaction.Commit();
                }
            }
            return int.Parse(id.ToString());
        }

        public static void DeleteUser(int userId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(session.Get<User>(userId));
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

        public static User GetUserById(int userId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<User>(userId);
            }
        }

        public static User GetUserByLogin(String userLogin)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.CreateCriteria(typeof(User))
                    .Add(Restrictions.Eq("Login", userLogin))
                    .UniqueResult<User>();
            }
        }

        public static User GetUserByRole(Roles role)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.CreateCriteria(typeof(User))
                    .Add(Restrictions.Eq("RoleRef", (int)role + 1))
                    .SetMaxResults(1)
                    .UniqueResult<User>();
            }
        }
    }
}
