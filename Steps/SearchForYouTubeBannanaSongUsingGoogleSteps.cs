using BananaSongTest.BusinessObjects;
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
            Browser.Instance.GoToUrl("https://www.gmail.com/");
        }

        [When(@"User submit username (*) and password (.*)")]
        public void WhenUserSubmitUsernameAndPassword(string userName, string password)
        {
            var signInPage = new SignInPage();
            signInPage.PopulateEmailAndClickEnter(userName);
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
        
        [When(@"User search for (.*)")]
        public void WhenUserSearchForBananaSong(string search)
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.SearchForKeyWords(search);
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

        [Given(@"User is signed in into Gmail")]
        public void GivenUserIsSignedInIntoGmail()
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.NavigateToGmail();
        }

        [Given(@"User is in the draft folder")]
        public void GivenUserIsInTheDraftFolder()
        {
            var gmailMainPage = new GmailMainPage();
            gmailMainPage.NavigateToDraft();
        }

        [When(@"User creates new email to send to (.*) with (.*) title and (.*) text")]
        public void WhenUserCreatesNewEmailWithNewTitle(string recipient, string title, string text)
        {
            var gmailMainPage = new GmailMainPage();
            gmailMainPage.ClickToComposeNewEmail();
            var newEmail = new EmailObject();
            newEmail.CreateNewEmail(recipient, title, text);
        }

        [When(@"User saves a new email to drafts")]
        public void WhenUserSavesANewEmailToDrafts()
        {
            var gmailMainPage = new GmailMainPage();
            gmailMainPage.ClickCloseButton();
        }

        [When(@"User send the draft email with (.*) title")]
        public void WhenUserSendTheDraftEmailToNewReceipenEmailRecipientEmail(string newTitle)
        {
            var email = new EmailObject();
            email.openEmailByTitle(newTitle);
            email.SendAnEmail();
        }

        [Then(@"New email with (.*) title is in draft folder")]
        public void ThenNewEmailWithNewTitleTitleIsInDraftFolder(string newTitle)
        {
            var email = new EmailObject();
            Assert.AreEqual(email.searchEmailsByTitleAndReturnQuantity("in:draft " + newTitle), 1);
        }

        [Then(@"Email with (.*) title is no longer in draft folder")]
        public void ThenEmailWithNewTitleTitleIsNoLongerInDraftFolder(string newTitle)
        {
            var email = new EmailObject();
            Assert.AreEqual(email.searchEmailsByTitleAndReturnQuantity("in:draft " + newTitle), 0);
        }

        [Then(@"Email with (.*) title is in sent folder")]
        public void ThenEmailWithNewTitleTitleIsInSentFolder(string newTitle)
        {
            var email = new EmailObject();
            Assert.AreEqual(email.searchEmailsByTitleAndReturnQuantity("in:sent " + newTitle), 0);
        }
    }
}
