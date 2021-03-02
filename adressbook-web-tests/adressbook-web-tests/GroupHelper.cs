using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests
{
    public class GroupHelper : HelperBase
    {
        private GroupsFormDto groupsFormDto;

        public GroupHelper(IWebDriver driver, GroupsFormDto groupsFormDto) : base(driver)
        {
            this.groupsFormDto = groupsFormDto;
        }
        public void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        public void DeleteSelectedGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }

        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        public void FillGroupForm(GroupsFormDto groupsFormDto)
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
        }
    }
}
