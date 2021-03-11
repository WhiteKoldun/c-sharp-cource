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
            string url = baseUrl + "/addressbook/group.php";
            GoToUrlMeth(url, By.Name("new"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return this;
        }

        public NavigationHelper GoToHomePage()
        {
            string url = baseUrl + "/addressbook/";
            GoToUrlMeth(url, By.XPath("//*"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return this;
        }
        public NavigationHelper GoToAddNewPage()
        {
            string url = baseUrl + "/addressbook/edit.php";
            GoToUrlMeth(url, By.Name("title"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return this;

        }

        public bool IsNotAlreadyOnPage(string url)
        {
            try
            {
                if (driver.Url == url)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public NavigationHelper GoToUrlMeth(string url, By by)
        {
            if (IsNotAlreadyOnPage(url)
            && IsElementPresent(by))
            {
                manager.Auth.LoginAdmin();
                driver.Navigate().GoToUrl(url);
                return this;
            }
            return this;
        }
    }
}
