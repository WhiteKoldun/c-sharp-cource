using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;

namespace adressbook_web_tests
{
    public class LoginHelper
    {
        private IWebDriver driver;

        public LoginHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login(AccountDto accountDto)
        {
            driver.FindElement(By.Name("user")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(accountDto.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(accountDto.Password);
            driver.FindElement(By.Id("LoginForm")).Click();
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
