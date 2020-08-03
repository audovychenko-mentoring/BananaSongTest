using BananaSongTest.Elements;
using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;

namespace BananaSongTest.main.Pages
{
    class YouTubePage
    {
        public UIElement views => new UIElement(By.XPath("//*[@class = 'view-count style-scope yt-view-count-renderer']"));

        public int returnViewsQuantity()
        {
            string viewsQuantity = views.WebElement.Text;
            Regex rx = new Regex(@"[0-9, ]+");
            MatchCollection matches = rx.Matches(viewsQuantity);
            String newString = matches[0].Groups[0].Value;
            String formattedString = newString.Replace(",", "").Replace(" ", "");
            int result = int.Parse(formattedString);
            return result;
        }

        public bool ValidateQuantityOfVideoViews(int expectedViews)
        {
            int viewsQuantity = returnViewsQuantity();
            if (viewsQuantity > expectedViews)
            {
                return true;
            }
            return false;
        }
    }
}
