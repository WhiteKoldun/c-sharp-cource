
using adressbook_web_tests.Dtos;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace adressbook_web_tests.Manager
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseUrl;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            Contact = new ContactHelper(this);
            Auth = new LoginHelper(this);
            Navigation = new NavigationHelper(this);
            Group = new GroupHelper(this);
            baseUrl = "http://localhost:8080";
        }
        ~ApplicationManager()
        {
            driver.Quit();
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated) //условие звучит как "если value не создано", то бишь, если в текущем треде нет обьекта этого класса
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigation.GoToHomePage();
                app.Value = newInstance;
                
            }
            return app.Value;
        }

        public LoginHelper Auth { get; set; }

        public NavigationHelper Navigation { get; set; }

        public ContactHelper Contact { get; set; }

        public GroupHelper Group { get; set; }

    }
}
