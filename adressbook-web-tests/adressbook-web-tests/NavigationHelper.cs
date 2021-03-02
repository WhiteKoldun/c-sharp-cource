using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests
{
    public class NavigationHelper : HelperBase
    {
        private string baseUrl;


        public NavigationHelper(IWebDriver driver, string baseUrl) : base(driver)
        {
            this.baseUrl = baseUrl;
        }
        public void GoToGroupsPage(string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/group.php");
        }

        public void GoToHomePage(string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/");
        }
        public void GoToAddNewPage(string baseUrl)
        {
            driver.Navigate().GoToUrl(baseUrl + "/addressbook/edit.php");
        }
    }
}
