using System;
using System.Text;
using NUnit.Framework;
using adressbook_web_tests.Manager;

namespace adressbook_web_tests.Tests
{
    public class TestBase
    {
        protected StringBuilder verificationErrors;
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
           verificationErrors = new StringBuilder();
           app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
        


        
    }
}
