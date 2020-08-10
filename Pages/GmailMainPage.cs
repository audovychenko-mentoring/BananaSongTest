using BananaSongTest.BusinessObjects;
using BananaSongTest.Elements;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace BananaSongTest.Pages
{
    class GmailMainPage
    {

        public UIElement InboxLink => new UIElement(By.XPath("//a[contains(text(),'Inbox')]"));

        public UIElement SentLink => new UIElement(By.XPath("//a[contains(text(),'Sent')]"));

        public UIElement DraftLink => new UIElement(By.XPath("//a[contains(text(),'Draft')]"));

        public UIElement ComposeButton => new UIElement(By.XPath("//div[contains(text(),'Compose')]"));

        public UIElement ToField => new UIElement(By.XPath("//*[@name = 'to']"));

        public UIElement SubjectField => new UIElement(By.XPath("//*[@name = 'subjectbox']"));

        public UIElement TextField => new UIElement(By.XPath("//div[@id=':9f']"));

        public UIElement AddAttachmentButton => new UIElement(By.Id(":9t"));

        public UIElement CloseButton => new UIElement(By.Id(":bw"));

        public UIElement EmailsTable => new UIElement(By.XPath("//table[@id=':1v']"));

        public UIElement DraftEmails => new UIElement(By.XPath("//tr[@class='zA yO']"));

        public UIElement SearchField => new UIElement(By.Id("aso_search_form_anchor"));

        public UIElement SendEmailButton => new UIElement(By.Id(":7c"));

        public void NavigateToInbox() 
        {
            InboxLink.WebElement.Click();
        }

        public void NavigateToSent()
        {
            SentLink.WebElement.Click();
        }

        public void NavigateToDraft()
        {
            DraftLink.WebElement.Click();
        }

        public void ClickToComposeNewEmail()
        {
            ComposeButton.WebElement.Click();
        }

        public void ClickSendEmailButton()
        {
            SendEmailButton.WebElement.Click();
        }

        public void PopulateToField(string to)
        {
            ToField.WebElement.SendKeys(to);
        }

        public void PopulateSubjectField(string subject)
        {
            SubjectField.WebElement.SendKeys(subject);
        }

        public void PopulateTextField(string text)
        {
            TextField.WebElement.SendKeys(text);
        }

        public void ClickAddAttachmentButton()
        {
            AddAttachmentButton.WebElement.Click();
        }

        public void ClickCloseButton()
        {
            CloseButton.WebElement.Click();
        }

        public void SearchForElement(string search)
        {
            TextField.WebElement.SendKeys(search);
            TextField.WebElement.SendKeys(Keys.Enter);
        }

        public int returnTheQuantityOfDraftEmails()
        {
            return DraftEmails.WebElements.Count;
        }

        public void ClickOnFirstEmailFromTheList()
        {
            DraftEmails.WebElement.Click();
        }
    }
}
