using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin","secret");
        private GroupsFormDto groupsForm = new GroupsFormDto("asdasd","rtynhrtyj","ASDad");
        
        [Test]
        public void CreateNewValidGroup()
        {
            OpenHomePage(baseURL);
            Login(adminAccount);
            GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(groupsForm);
            SubmitGroupCreation();
            GoToGroupsPage();
            Logout();
        }
    }
}
