using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests.Manager
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public GroupHelper CheckAnyGroupExist(GroupsFormDto groupsForm)
        {
            if (IsElementPresent(By.XPath("(//input[@name='selected[]'])")))
            {
                return this;
            }
            else
            {
                Create(groupsForm);
            }

            return this;
        }
        public GroupHelper Create(GroupsFormDto groupsFormValid)
        {
            
            manager.Navigation.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(groupsFormValid);
            SubmitGroupCreation();
            manager.Navigation.GoToGroupsPage();
            return this;
        }
        public GroupHelper Delete(int v)
        {
            manager.Navigation.GoToGroupsPage();
            SelectGroup(v);
            DeleteSelectedGroup();
            manager.Navigation.GoToGroupsPage();
            return this;
        }
        public GroupHelper Modify(int groupToModify, GroupsFormDto dataToModify)
        {
            manager.Navigation.GoToGroupsPage();
            SelectGroup(groupToModify);
            InitGroupModification();
            FillGroupForm(dataToModify);
            SubmitGroupModification();
            manager.Navigation.GoToGroupsPage();
            return this;
        }

        

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        

        public GroupHelper DeleteSelectedGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupsFormDto groupsFormDto)
        {
            Type(By.Name("group_name"), groupsFormDto.Name);
            Type(By.Name("group_header"), groupsFormDto.Header);
            Type(By.Name("group_footer"), groupsFormDto.Footer);
            driver.FindElement(By.Id("content")).Click();
            return this;
        }

        

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

    }
}
