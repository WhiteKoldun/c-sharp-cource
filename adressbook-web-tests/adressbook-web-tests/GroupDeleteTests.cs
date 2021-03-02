using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests
{
    [TestFixture]
    public class DeleteExistGroup : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin", "secret");
        [Test]
        public void DeleteExistGroupTest()
        {
            navigator.GoToHomePage(baseURL);
            loginHelper.Login(adminAccount);
            navigator.GoToGroupsPage(baseURL);
            groupHelper.SelectGroup(1);
            groupHelper.DeleteSelectedGroup();
            navigator.GoToGroupsPage(baseURL);
            loginHelper.Logout();
        }
    }
}
