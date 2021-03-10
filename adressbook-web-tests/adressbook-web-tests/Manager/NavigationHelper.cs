using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests.Manager
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
        }
        public NavigationHelper GoToGroupsPage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/group.php");
            return this;
        }

        public NavigationHelper GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/");
            return this;
        }
        public NavigationHelper GoToAddNewPage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/edit.php");
            return this;
        }
    }
}
