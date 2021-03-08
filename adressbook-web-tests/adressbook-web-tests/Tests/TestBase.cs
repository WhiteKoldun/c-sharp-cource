using System;
using System.Text;
using adressbook_web_tests.Dtos;
using NUnit.Framework;
using adressbook_web_tests.Manager;

namespace adressbook_web_tests.Tests
{
    public class TestBase
    {
        protected StringBuilder verificationErrors;
        protected ApplicationManager app;
        private AccountDto adminAccount = new AccountDto("admin", "secret");

        [SetUp]
        public void SetupTest()
        {
           verificationErrors = new StringBuilder();
           app = new ApplicationManager();
           app.Navigation.GoToHomePage();
           app.Auth.Login(adminAccount);
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
        


        
    }
}
