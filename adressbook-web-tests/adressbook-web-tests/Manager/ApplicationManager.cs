
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace adressbook_web_tests.Manager
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected GroupsFormDto groupsFormDto;
        protected ContactsFormDto contactsFormDto;
        
        public ApplicationManager()
        {
            contactsFormDto = new ContactsFormDto();
            groupsFormDto = new GroupsFormDto("asdasd", "rtynhrtyj", "ASDad");
            driver = new FirefoxDriver();
            baseURL = "http://localhost:8080";
            Contact = new ContactHelper(driver, contactsFormDto);
            Auth = new LoginHelper(driver);
            Navigation = new NavigationHelper(driver, baseURL);
            Group = new GroupHelper(driver, groupsFormDto);
        }

        public void Stop()
        {
            driver.Quit();
        }

        public LoginHelper Auth { get; set; }
        public NavigationHelper Navigation { get; set; }
        public ContactHelper Contact { get; set; }
        public GroupHelper Group { get; set; }
        
    }
}
