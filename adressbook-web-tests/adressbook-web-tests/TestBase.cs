using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using adressbook_web_tests.Dtos;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace adressbook_web_tests
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected GroupsFormDto groupsFormDto;
        protected ContactsFormDto contactsFormDto;
        protected ContactHelper contact;
            [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:8080";
            verificationErrors = new StringBuilder();
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver,baseURL);
            groupHelper = new GroupHelper(driver, groupsFormDto);
            contactsFormDto = new ContactsFormDto();
            contact = new ContactHelper(driver,contactsFormDto);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        


        
    }
}
