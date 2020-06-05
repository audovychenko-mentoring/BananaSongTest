using BananaSongTest.Elements;
using OpenQA.Selenium;

namespace BananaSongTest.Pages
{
    class GoogleSearchPage
    {
        public UIElement SearchField => new UIElement(By.XPath("//input[@type='text']"));

        public UIElement DespicableMeLink => new UIElement(By.XPath("//h3[contains(text(),'Despicable Me')]"));

        public void SearchForKeyWords(string searchRequest) 
        {
            SearchField.WebElement.SendKeys(searchRequest);
        }

        public void ConfirmSelection()
        {
            SearchField.WebElement.SendKeys(Keys.Enter);
        }

        public void NavigateToYouTubeDespicableMeVideo()
        {
            DespicableMeLink.WebElement.Click();
        }
    }
}
