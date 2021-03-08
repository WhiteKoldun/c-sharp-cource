using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests
{
    [TestFixture]
    public class CreateNewContact : TestBase
    {
        private ContactsFormDto contactsForm = new ContactsFormDto();
        
        [Test]
        public void CreateNewValidContact()
        {
            app.Navigation.GoToAddNewPage();
            app.Contact.FillContactForm(contactsForm);
            app.Contact.SubmitContactCreation();
            app.Navigation.GoToHomePage();
            app.Auth.Logout();
        }
    }
}
