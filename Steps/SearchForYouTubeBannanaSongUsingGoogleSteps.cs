using BananaSongTest.main.Pages;
using BananaSongTest.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BananaSongTest
{
    [Binding]
    public class SearchForYouTubeBannanaSongUsingGoogleSteps
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Browser.Instance.CloseBrowser();
        }

        [Given(@"User navigate to the login page")]
        public void GivenUserNavigateToTheLoginPage()
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.NavigateToSignInPage();
        }

        [When(@"User submit username and password (.*)")]
        public void WhenUserSubmitUsernameAndPassword(string password)
        {
            var signInPage = new SignInPage();
            signInPage.SelectDefaultProfile();
            signInPage.EnterPassword(password);
        }

        [Then(@"User should be logged into (.*) account")]
        public void UserShouldBeLoggedIn(string accountTitle)
        {
            var googleSearchPage = new GoogleSearchPage();
            Assert.IsNotNull(googleSearchPage.ReturnLoggedInIcon());
        }

        [Given(@"User is on the Google search page")]
        public void GivenUserIsOnTheGoogleSearchPage()
        {
            Browser.Instance.GoToUrl("https://www.google.com/");
        }
        
        [When(@"User search for banana song")]
        public void WhenUserSearchForBananaSong()
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.SearchForKeyWords("Banana Song");
            googleSearchPage.ConfirmSelection();
        }
        
        [When(@"User selects YouTube link to navigate")]
        public void WhenUserSelectsYouTubeLinkToNavigate()
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.NavigateToYouTubeDespicableMeVideo();
        }
        
        [Then(@"User is on the page with (.*) title")]
        public void ThenUserIsOnThePageWithYouTubeTitle(string pageTitle)
        {
            Assert.IsTrue(Browser.Instance.Driver.Title.Contains(pageTitle));
        }
        
        [Then(@"Views quantity for the banana song video is more than (.*)")]
        public void ThenViewsQuantityForTheBananaSongVideoIsMoreThan(int expectedViews)
        {
            YouTubePage youTubePage = new YouTubePage();
            Assert.IsTrue(youTubePage.ValidateQuantityOfVideoViews(expectedViews));
        }
    }
}
