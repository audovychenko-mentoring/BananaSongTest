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
        public static IWebDriver GetDriver(BrowserType browser)
        {
            switch (browser)
            {
               // case BrowserType.Chrome:
               //     return new ChromeDriver();
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                default:
                    throw new Exception("Unknown driver");
            }
        }
    }
}
