using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSongTest
{
    class BrowserFactory
    {
        public static IWebDriver GetDriver(BrowserType browser, BrowserLocale locale)
        {
            switch (browser)
            {
               // case BrowserType.Chrome:
               //     return new ChromeDriver();
                case BrowserType.Firefox:
                    FirefoxOptions options = new FirefoxOptions();
                    options.SetPreference("intl.accept_languages", locale.ToString());
                    return new FirefoxDriver(options);
                default:
                    throw new Exception("Unknown driver");
            }
        }
    }
}
