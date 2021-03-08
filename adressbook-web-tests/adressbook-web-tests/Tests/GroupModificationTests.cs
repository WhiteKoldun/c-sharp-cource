using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using adressbook_web_tests.Dtos;

namespace adressbook_web_tests.Tests
{
    public class GroupModificationTests : TestBase
    {
        GroupsFormDto dataToModify = new GroupsFormDto("name mod","head mod","foot mod");
        private int groupToModify = 1;
        //[Test]
        public void GroupModificationTest()
        {
            app.Group.Modify(groupToModify, dataToModify);
        }
    }
}
