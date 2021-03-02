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
            navigator.GoToHomePage(baseURL);
            loginHelper.Login(adminAccount);
            navigator.GoToGroupsPage(baseURL);
            groupHelper.InitGroupCreation();
            groupHelper.FillGroupForm(groupsForm);
            groupHelper.SubmitGroupCreation();
            navigator.GoToGroupsPage(baseURL);
            loginHelper.Logout();
        }
    }
}
