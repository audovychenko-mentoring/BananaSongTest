using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSongTest.Elements
{
    public class UIElement
    {
        public By Locator { get; }

        public UIElement(By locator)
        {
            Locator = locator;
        }

        public IWebElement WebElement
        {
            get
            {
                return Browser.Instance.Driver.FindElement(Locator);
            }
        }

    }
}
