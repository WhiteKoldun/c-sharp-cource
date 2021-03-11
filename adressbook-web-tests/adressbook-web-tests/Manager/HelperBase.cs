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
            this.driver = manager.Driver;
            this.manager = manager;

        }
        public HelperBase Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            return this;
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}