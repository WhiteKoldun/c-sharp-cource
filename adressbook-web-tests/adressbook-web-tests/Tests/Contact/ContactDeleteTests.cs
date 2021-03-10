using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class ContactDeleteTests : TestBase
    {
        [Test]
        public void DeleteExistContact()
        {
            //app.Contact.Delete(contactNumber);
            app.Contact.DeleteFirstExist();
            app.Auth.Logout();
        }

    }
}
