using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin","secret");
        private GroupsFormDto groupsForm = new GroupsFormDto("asdasd","rtynhrtyj","ASDad");
        
        [Test]
        public void CreateNewValidGroup()
        {
            app.Navigation.GoToHomePage();
            app.Auth.Login(adminAccount);
            app.Navigation.GoToGroupsPage();
            app.Group.InitGroupCreation();
            app.Group.FillGroupForm(groupsForm);
            app.Group.SubmitGroupCreation();
            app.Navigation.GoToGroupsPage();
            app.Auth.Logout();
        }
    }
}
