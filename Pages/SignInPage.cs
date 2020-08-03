using BananaSongTest.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BananaSongTest.Pages
{
    class SignInPage
    {
        public UIElement optionForDefaultProfile => new UIElement(By.XPath("//*[@id = 'profileIdentifier']"));

        public UIElement passwordField => new UIElement(By.XPath("//input[@name='password']"));

        public IWebElement nextButton = Browser.Instance.Driver.FindElement(By.XPath("//*[@class = 'VfPpkd-RLmnJb']"));

        public void SelectDefaultProfile()
        {
            optionForDefaultProfile.WebElement.Click();
        }

        public void EnterPassword(string password)
        {
            passwordField.WebElement.SendKeys(password);
        }

        public void ClickNextButton()
        {
            nextButton.Click();
        }
    }
}
