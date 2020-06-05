using BananaSongTest.main.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BananaSongTest.test.Assertions
{
    class BananaSongAssertion
    {
        public static void ValidatePageTitle(string pageTitle)
        {
            Assert.IsTrue(Browser.Instance.Driver.Title.Contains(pageTitle));
        }

        public static void ViewsMoreThanExpectedResultAssertion(int expectedViews)
        {
            YouTubePage youTubePage = new YouTubePage();
            Assert.IsTrue(youTubePage.ValidateQuantityOfVideoViews(expectedViews));
        }
    }
}
