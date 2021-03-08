using OpenQA.Selenium;

namespace adressbook_web_tests.Manager
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;
        protected string baseUrl = "http://localhost:8080";

        public HelperBase(ApplicationManager manager)
        {
            driver = manager.Driver;
            this.manager = manager;

        }
    }
}