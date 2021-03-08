
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace adressbook_web_tests.Manager
{
    public class ApplicationManager
    {
        protected IWebDriver driver;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            Contact = new ContactHelper(driver);
            Auth = new LoginHelper(driver);
            Navigation = new NavigationHelper(driver);
            Group = new GroupHelper(driver);
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
