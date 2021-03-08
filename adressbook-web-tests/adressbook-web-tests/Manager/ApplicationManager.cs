
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace adressbook_web_tests.Manager
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseUrl;



        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            Contact = new ContactHelper(this);
            Auth = new LoginHelper(this);
            Navigation = new NavigationHelper(this);
            Group = new GroupHelper(this);
            baseUrl = "http://localhost:8080";
    }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
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
