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
        private string baseUrl = "http://localhost:8080";


        public NavigationHelper(IWebDriver driver) : base(driver)
        {
        }
        public void GoToGroupsPage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/group.php");
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/");
        }
        public void GoToAddNewPage()
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/edit.php");
        }
    }
}
