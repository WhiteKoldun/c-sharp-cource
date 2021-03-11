using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests.Manager
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }

        public LoginHelper Login(AccountDto accountDto)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(accountDto))
                {
                    return this;
                }

                Logout();
            }
            Type(By.Name("user"), accountDto.Username);
            Type(By.Name("pass"), accountDto.Password);
            driver.FindElement(By.Id("LoginForm")).Click();
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return this;
        }

        public LoginHelper Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            }

            return this;
        }
        public bool IsLoggedIn(AccountDto accountDto)
        {
            return IsLoggedIn()
                   && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                   == "(" + accountDto.Username + ")";
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }
        public LoginHelper LoginAdmin()
        {
            Login(new AccountDto("admin", "secret"));
            return this;
        }
    }
}
