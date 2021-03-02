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
            OpenHomePage(baseURL);
            Login(adminAccount);
            GoToGroupsPage();
            SelectGroup(1);
            DeleteSelectedGroup();
            GoToGroupsPage();
            Logout();
        }
    }
}
