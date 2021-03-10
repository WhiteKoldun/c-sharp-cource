using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        GroupsFormDto dataToModify = new GroupsFormDto("name mod","head mod","foot mod");
        GroupsFormDto dataToModifyOneField = new GroupsFormDto(null, "ONLY head mod", null);
        private int groupToModify = 1;
        [Test]
        public void GroupModificationTestAllFileds()
        {
            app.Group.Modify(groupToModify, dataToModify);
            app.Auth.Logout();
        }
        [Test]
        public void GroupModificationTestOneFiled()
        {
            app.Group.Modify(groupToModify, dataToModifyOneField);
            app.Auth.Logout();
        }
    }
}
