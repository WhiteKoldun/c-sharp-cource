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
            Type(By.Name("user"), accountDto.Username);
            Type(By.Name("pass"), accountDto.Password);
            driver.FindElement(By.Id("LoginForm")).Click();
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            return this;
        }
        public LoginHelper Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
    }
}
