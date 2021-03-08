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
            manager.Group.SelectGroup(v)
                .DeleteSelectedGroup();
            manager.Navigation.GoToGroupsPage();
            return this;
        }
        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper Modify(int groupToModify, GroupsFormDto dataToModify)
        {
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
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(groupsFormDto.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(groupsFormDto.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupsFormDto.Footer);
            driver.FindElement(By.Id("content")).Click();
            return this;
        }

        
    }
}
