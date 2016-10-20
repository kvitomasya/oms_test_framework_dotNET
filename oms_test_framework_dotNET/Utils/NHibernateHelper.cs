using NHibernate;
using NHibernate.Cfg;

namespace oms_test_framework_dotNET.Utils
{
    public sealed class NHibernateHelper
    {

        private NHibernateHelper()
        {

        }

        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    sessionFactory = new Configuration().Configure().BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }

}
