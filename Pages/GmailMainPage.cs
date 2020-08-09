using BananaSongTest.Elements;
using OpenQA.Selenium;

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

        public UIElement AddAttachmentButton => new UIElement(By.XPath("//*[@id = ':9t']"));

        public UIElement CloseButton => new UIElement(By.XPath("//*[@id = ':bw']"));

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
    }
}
