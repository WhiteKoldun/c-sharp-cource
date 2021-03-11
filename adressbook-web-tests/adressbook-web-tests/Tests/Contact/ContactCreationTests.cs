using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class CreateNewContact : AuthTestBase
    {
        private ContactsFormDto contactsForm = new ContactsFormDto();
        
        [Test]
        public void CreateNewValidContact()
        {
            app.Contact.Create(contactsForm);
            
        }
    }
}
