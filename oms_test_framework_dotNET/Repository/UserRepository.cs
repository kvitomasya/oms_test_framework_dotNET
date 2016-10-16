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
using oms_test_framework_dotNET.Enums;

namespace oms_test_framework_dotNET.Repository
{
    public class UserRepository : IUserRepository
    {
        private const String ResetAutoIncrementQuery = "ALTER TABLE Users AUTO_INCREMENT=0;";

        public int CreateUser(User user)
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

        public void DeleteUser(int userId)
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

        public User GetUserById(int userId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<User>(userId);
            }
        }

        public User GetUserByLogin(string userLogin)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.CreateCriteria(typeof(User))
                    .Add(Restrictions.Eq("Login", userLogin))
                    .UniqueResult<User>();
            }
        }

        public User GetUserByRole(Roles role)
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
