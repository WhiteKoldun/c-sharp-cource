using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class DeleteExistGroup : AuthTestBase
    {
        GroupsFormDto dataToModify = new GroupsFormDto("name mod", "head mod", "foot mod");
        [Test]
        public void DeleteExistGroupTest()
        {
            app.Group.CheckAnyGroupExist(dataToModify);
            app.Group.Delete(1);
            
        }
    }
}
