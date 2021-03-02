using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests
{
    [TestFixture]
    public class CreateNewContact : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin", "secret");
        private ContactsFormDto contactsForm = new ContactsFormDto();
        
        [Test]
        public void CreateNewValidContact()
        {
            navigator.GoToHomePage(baseURL);
            loginHelper.Login(adminAccount);
            navigator.GoToAddNewPage(baseURL);
            contact.FillContactForm(contactsForm);
            contact.SubmitContactCreation();
            navigator.GoToHomePage(baseURL);
            loginHelper.Logout();
        }
    }
}
