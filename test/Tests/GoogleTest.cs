using BananaSongTest.main.Pages;
using BananaSongTest.test.Assertions;
using BananaSongTest.test.Steps;
using NUnit.Framework;

namespace BananaSongTest.test.Tests
{
    [TestFixture]
    class GoogleTest
    {
        [Test]
        public void BananaSongTest()
        {
            BananaSongSteps.NavigateToGoogle();
            BananaSongSteps.SearchForBananaSongAndNavigateToYouTube();
            BananaSongAssertion.ValidatePageTitle("YouTube");
            BananaSongAssertion.ViewsMoreThanExpectedResultAssertion(50000000);
            Browser.Instance.CloseBrowser();
        }      
    }
}
