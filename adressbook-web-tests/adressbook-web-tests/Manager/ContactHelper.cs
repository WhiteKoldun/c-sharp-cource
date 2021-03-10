using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace adressbook_web_tests.Manager
{
    public class ContactHelper : HelperBase
    {
        
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper Create(ContactsFormDto contactsForm)
        {
            manager.Navigation.GoToAddNewPage();
            FillContactForm(contactsForm);
            SubmitContactCreation();
            manager.Navigation.GoToHomePage();
            return this;
        }
        public ContactHelper Delete(int contactNumber)
        {
            manager.Navigation.GoToHomePage();
            SelectContactById(contactNumber);
            ConfirmDelete();
            manager.Navigation.GoToHomePage();
            return this;
        }
        public ContactHelper DeleteFirstExist()
        {
            manager.Navigation.GoToHomePage();
            SelectExistContact();
            ConfirmDelete();
            manager.Navigation.GoToHomePage();
            return this;
        }
        public ContactHelper Modify(int contactPosition,ContactsFormDto contactsForm)
        {
            manager.Navigation.GoToHomePage();
            InitEditionOfContact(contactPosition);
            FillContactForm(contactsForm);
            SubmitContactUpdate();
            manager.Navigation.GoToHomePage();
            return this;
        }
        public ContactHelper ConfirmDelete()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper InitEditionOfContact(int contactPosition)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])["+contactPosition+"]")).Click();
            return this;
        }

        public ContactHelper SelectExistContact()
        {
            int i;
            string id = null;
            for (i = 1; id == null; i++) 
            {
                try
                {
                    driver.FindElement(By.XPath("//input[@type='checkbox' and @name='selected[]' and @value= '"+i+ "' and @title = 'Select (first name text last name text)']")).Click();
                    id = "ne null";
                }
                catch
                {
                   continue;
                }
            }
            return this;
        }
        public ContactHelper SelectContactById(int contactNumber)
        {
            driver.FindElement(By.XPath("//input[@type='checkbox' and @name='selected[]' and @value= '" + contactNumber + "' and @title = 'Select (first name text last name text)']")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        public ContactHelper SubmitContactUpdate()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactsFormDto contactsFormDto)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactsFormDto.Firstname);
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contactsFormDto.Middlename);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactsFormDto.Lastname);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contactsFormDto.Nickname);
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contactsFormDto.Title);
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contactsFormDto.Company);
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contactsFormDto.Address);
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contactsFormDto.Home);
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contactsFormDto.Mobile);
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contactsFormDto.Work);
            driver.FindElement(By.Name("fax")).Click();
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(contactsFormDto.Fax);
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contactsFormDto.Email);
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(contactsFormDto.Email2);
            driver.FindElement(By.Name("email3")).Click();
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(contactsFormDto.Email3);
            driver.FindElement(By.Name("homepage")).Click();
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(contactsFormDto.Homepage);
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contactsFormDto.DateBirth.Day.ToString());
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contactsFormDto.BMonth);
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys(contactsFormDto.DateBirth.Year.ToString());
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contactsFormDto.DateA.Day.ToString());
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contactsFormDto.AMonth);
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys(contactsFormDto.DateA.Year.ToString());
            driver.FindElement(By.Name("address2")).Click();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contactsFormDto.Address2);
            driver.FindElement(By.Name("phone2")).Click();
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(contactsFormDto.Phone2);
            driver.FindElement(By.Name("notes")).Click();
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(contactsFormDto.Notes);
            //driver.FindElement(By.Name("theform")).Click();
            return this;
        }

        
    }
}
