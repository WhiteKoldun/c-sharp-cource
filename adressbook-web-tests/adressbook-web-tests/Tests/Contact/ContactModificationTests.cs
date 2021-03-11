using NUnit.Framework;
using adressbook_web_tests.Dtos;
using System;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        private ContactsFormDto contactsForm = new ContactsFormDto();
        [Test]
        public void ContactModificationTest()
        {
            contactsForm.Lastname = "LAST NAME MODIFY";
            app.Contact.Modify(1, contactsForm);
            app.Auth.Logout();
        }
    }
}
