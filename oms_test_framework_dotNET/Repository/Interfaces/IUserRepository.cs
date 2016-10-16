using oms_test_framework_dotNET.Domains;
using oms_test_framework_dotNET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Repository.Interfaces
{
    public interface IUserRepository
    {
        int CreateUser(User user);

        User GetUserById(int userId);

        User GetUserByLogin(String userLogin);

        User GetUserByRole(Roles role);

        void DeleteUser(int userId);
    }
}
