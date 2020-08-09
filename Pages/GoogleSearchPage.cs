using BananaSongTest.Elements;
using OpenQA.Selenium;

namespace BananaSongTest.Pages
{
    class GoogleSearchPage
    {
        public UIElement SearchField => new UIElement(By.XPath("//input[@type='text']"));

        public UIElement DespicableMeLink => new UIElement(By.XPath("//h3[contains(text(),'Despicable Me')]"));

        public UIElement SignInButton => new UIElement(By.XPath("//a[@id = 'gb_70']"));

        public UIElement LoggedInIcon => new UIElement(By.XPath("//*[@title = '${accountTitle}']"));

        public UIElement GmailLink => new UIElement(By.XPath("//a[contains(text(), 'Gmail')]"));

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

        public void NavigateToSignInPage()
        {
            SignInButton.WebElement.Click();
        }

        public void NavigateToGmail()
        {
            GmailLink.WebElement.Click();
        }

        public UIElement ReturnLoggedInIcon()
        {
            return LoggedInIcon;
        }
    }
}
