using System;
using System.Text;
using adressbook_web_tests.Dtos;
using NUnit.Framework;
using adressbook_web_tests.Manager;

namespace adressbook_web_tests.Tests
{
    public class TestBase
    {
        protected ApplicationManager app;
        private AccountDto adminAccount = new AccountDto("admin", "secret");

        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();
           app.Auth.Login(adminAccount);
        }
    }
}
