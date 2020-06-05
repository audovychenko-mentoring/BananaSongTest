using BananaSongTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace BananaSongTest.test.Steps
{
    public class BananaSongSteps
    {
        public static void NavigateToGoogle()
        {
            Browser.Instance.GoToUrl("https://www.google.com/");
        }

        public static void SearchForBananaSongAndNavigateToYouTube()
        {
            var googleSearchPage = new GoogleSearchPage();
            googleSearchPage.SearchForKeyWords("Banana Song");
            googleSearchPage.ConfirmSelection();
            googleSearchPage.NavigateToYouTubeDespicableMeVideo();
        }
    }
}
