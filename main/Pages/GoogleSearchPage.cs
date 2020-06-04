using BananaSongTest.Elements;
using OpenQA.Selenium;

namespace BananaSongTest.Pages
{
    class GoogleSearchPage
    {
        public UIElement SearchField => new UIElement(By.XPath("//*[@title='Search']"));

        public void SearchForKeyWords(string searchRequest) 
        {
            SearchField.WebElement.SendKeys(searchRequest);
        }

        public void ConfirmSelection()
        {
            SearchField.WebElement.SendKeys(Keys.Enter);
        }
    }
}
