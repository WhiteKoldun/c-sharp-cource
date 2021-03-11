using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests.Contact
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        
        private GroupsFormDto groupsFormValid = new GroupsFormDto("asdasd","rtynhrtyj","ASDad");
        private GroupsFormDto groupsFormEmpty = new GroupsFormDto("", "", "");

        [Test]
        public void CreateNewValidGroup()
        {
            app.Group.Create(groupsFormValid);
         
        }
        [Test]
        public void CreateNewEmptyGroup()
        {
            app.Group.Create(groupsFormEmpty);
            
        }
    }
}
