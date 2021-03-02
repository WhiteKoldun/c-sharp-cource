using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests
{
    [TestFixture]
    public class CreateNewContact : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin", "secret");
        private ContactsFormDto contactsForm = new ContactsFormDto();
        
        [Test]
        public void CreateNewValidContact()
        {
            app.Navigation.GoToHomePage();
            app.Auth.Login(adminAccount);
            app.Navigation.GoToAddNewPage();
            app.Contact.FillContactForm(contactsForm);
            app.Contact.SubmitContactCreation();
            app.Navigation.GoToHomePage();
            app.Auth.Logout();
        }
    }
}
