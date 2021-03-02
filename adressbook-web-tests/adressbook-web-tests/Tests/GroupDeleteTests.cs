using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests
{
    [TestFixture]
    public class DeleteExistGroup : TestBase
    {
        private AccountDto adminAccount = new AccountDto("admin", "secret");
        [Test]
        public void DeleteExistGroupTest()
        {
            app.Navigation.GoToHomePage();
            app.Auth.Login(adminAccount);
            app.Navigation.GoToGroupsPage();
            app.Group.SelectGroup(1);
            app.Group.DeleteSelectedGroup();
            app.Navigation.GoToGroupsPage();
            app.Auth.Logout();
        }
    }
}
