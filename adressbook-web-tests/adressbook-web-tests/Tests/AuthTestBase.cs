using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using adressbook_web_tests.Manager;
using NUnit.Framework;

namespace adressbook_web_tests.Tests
{
    public class AuthTestBase : TestBase
    {
        public AccountDto adminAccount = new AccountDto("admin", "secret");
        [SetUp]
        public void SetupLogin()
        {
            app.Auth.Login(adminAccount);
        }

        [TearDown]
        public void EndWithLogout()
        {
            app.Auth.Logout();
        }
    }
}
