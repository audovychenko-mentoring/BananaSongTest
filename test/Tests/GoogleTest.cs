using BananaSongTest.test.Steps;


namespace BananaSongTest.test.Tests
{   
    class GoogleTest
    {
        public void BananaSongTest()
        {
            BananaSongSteps.NavigateToGoogle();
            BananaSongSteps.SearchForBananaSong();

            Browser.Instance.CloseBrowser();
        }      
    }
}
