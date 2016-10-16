using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Domains
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual int IsUserActive { get; set; }
        public virtual int Balance { get; set; }
        public virtual String Email { get; set; }
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual String Login { get; set; }
        public virtual String Password { get; set; }
        public virtual int CustomerTypeRef { get; set; }
        public virtual int RegionRef { get; set; }
        public virtual int RoleRef { get; set; }

        protected User()
        {

        }

        public static FirstIdStep NewBuilder()
        {
            return new Builder();
        }

        public interface FirstIdStep
        {
            UserActiveStep SetId(int id);
        }

        public interface UserActiveStep
        {
            BalanceStep SetUserActive(int userActive);
        }

        public interface BalanceStep
        {
            EmailStep SetBalance(int balance);
        }

        public interface EmailStep
        {
            FirstNameStep SetEmail(String email);
        }

        public interface FirstNameStep
        {
            LastNameStep SetFirstName(String firstName);
        }

        public interface LastNameStep
        {
            LoginStep SetLastName(String lastName);
        }

        public interface LoginStep
        {
            PasswordStep SetLogin(String login);
        }

        public interface PasswordStep
        {
            CustomerTypeReferenceStep SetPassword(String password);
        }

        public interface CustomerTypeReferenceStep
        {
            RegionReferenceStep SetCustomerTypeReference(int customerTypeReference);
        }

        public interface RegionReferenceStep
        {
            RoleReferenceStep SetRegionReference(int regionReference);
        }

        public interface RoleReferenceStep
        {
            BuildStep SetRoleReference(int roleReference);
        }

        public interface BuildStep
        {
            User Build();
        }

        private class Builder : FirstIdStep, UserActiveStep, BalanceStep,
                EmailStep, FirstNameStep, LastNameStep, LoginStep, PasswordStep,
                CustomerTypeReferenceStep, RegionReferenceStep, RoleReferenceStep, BuildStep
        {

            private int id;
            private int userActive;
            private int balance;
            private String email;
            private String firstName;
            private String lastName;
            private String login;
            private String password;
            private int customerTypeReference;
            private int regionReference;
            private int roleReference;

            public UserActiveStep SetId(int id)
            {
                this.id = id;
                return this;
            }

            public BalanceStep SetUserActive(int userActive)
            {
                this.userActive = userActive;
                return this;
            }

            public EmailStep SetBalance(int balance)
            {
                this.balance = balance;
                return this;
            }

            public FirstNameStep SetEmail(String email)
            {
                this.email = email;
                return this;
            }

            public LastNameStep SetFirstName(String firstName)
            {
                this.firstName = firstName;
                return this;
            }

            public LoginStep SetLastName(String lastName)
            {
                this.lastName = lastName;
                return this;
            }

            public PasswordStep SetLogin(String login)
            {
                this.login = login;
                return this;
            }

            public CustomerTypeReferenceStep SetPassword(String password)
            {
                this.password = password;
                return this;
            }

            public RegionReferenceStep SetCustomerTypeReference(int customerTypeReference)
            {
                this.customerTypeReference = customerTypeReference;
                return this;
            }

            public RoleReferenceStep SetRegionReference(int regionReference)
            {
                this.regionReference = regionReference;
                return this;
            }

            public BuildStep SetRoleReference(int roleReference)
            {
                this.roleReference = roleReference;
                return this;
            }

            public User Build()
            {

                User user = new User();

                user.Id = id;
                user.IsUserActive = userActive;
                user.Balance = balance;
                user.Email = email;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Login = login;
                user.Password = password;
                user.CustomerTypeRef = customerTypeReference;
                user.RegionRef = regionReference;
                user.RoleRef = roleReference;

                return user;
            }
        }

        public override String ToString()
        {

            return "User {" +
                    "ID=" + Id +
                    ", isUserActive=" + IsUserActive +
                    ", Balance=" + Balance +
                    ", Email=" + Email +
                    ", FirstName=" + FirstName +
                    ", LastName=" + LastName +
                    ", Login=" + Login +
                    ", Password=" + Password +
                    ", CustomerTypeRef=" + CustomerTypeRef +
                    ", RegionRef=" + RegionRef +
                    ", RoleRef=" + RoleRef +
                    "}";
        }
    }
}
