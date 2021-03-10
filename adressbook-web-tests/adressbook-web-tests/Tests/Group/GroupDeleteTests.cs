using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class DeleteExistGroup : TestBase
    {
        [Test]
        public void DeleteExistGroupTest()
        {
            app.Group.Delete(1);
            app.Auth.Logout();
        }
    }
}
