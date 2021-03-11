using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using NUnit.Framework;

namespace adressbook_web_tests.Tests.Login
{
    [TestFixture]
    public class LoginTests : TestBase // авторизация не требуется
    {
        AccountDto accountValid = new AccountDto("admin","secret");
        AccountDto accountInValid = new AccountDto("admin", "wrong");
        [Test]
        public void LoginWithValidCreds()
        {
            app.Auth.Logout();
            app.Auth.Login(accountValid);
            Assert.IsTrue(app.Auth.IsLoggedIn(accountValid));
        }
        [Test]
        public void LoginWithInValidCreds()
        {
            app.Auth.Logout();
            app.Auth.Login(accountInValid);
            Assert.IsFalse(app.Auth.IsLoggedIn());
        }
    }
}
