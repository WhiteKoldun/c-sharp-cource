using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        GroupsFormDto dataToModify = new GroupsFormDto("name mod", "head mod", "foot mod");
        GroupsFormDto dataToModifyOneField = new GroupsFormDto(null, "ONLY head mod", null);
        private int groupToModify = 1;
        [Test]
        public void GroupModificationTestAllFields()
        {
            app.Group.CheckAnyGroupExist(dataToModify);
            app.Group.Modify(groupToModify, dataToModify);
            
        }
        [Test]
        public void GroupModificationTestOneFiled()
        {
            app.Group.CheckAnyGroupExist(dataToModify);
            app.Group.Modify(groupToModify, dataToModifyOneField);
            
        }
    }
}
