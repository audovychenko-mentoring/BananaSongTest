using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSongTest

{
    class Browser
    {
        private static readonly Browser instance = new Browser();

        static Browser()
        { 
        }

        public static Browser Instance
        {
            get { return instance; }
        }

        private IWebDriver driver;

        public IWebDriver Driver
        {
            get 
            {
                if (driver == null) InitBrowser(BrowserType.Firefox);
                return driver;
            }
        }

        public void InitBrowser(BrowserType browser)
        {
            driver = BrowserFactory.GetDriver(browser);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            if (driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
            driver = null;
        }
    }
}
