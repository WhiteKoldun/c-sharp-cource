﻿using NUnit.Framework;
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
            OpenHomePage(baseURL);
            Login(adminAccount);
            InitContactCreation();
            FillContactForm(contactsForm);
            SubmitContactCreation();
            GoToHomepage();
            Logout();
        }
    }
}
