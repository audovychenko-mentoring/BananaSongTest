using BananaSongTest.Pages;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BananaSongTest.BusinessObjects
{
    public class EmailObject
    {
        public DateTime creationTime;
        public string status;
        public string type;
        public string subject;

        public NewEmail CreateNewEmail(string to, string subject, string text)
        {
            return new NewEmail(to, subject, text);
        }

        public void DeleteAnEmail()
        {
        }

        public void SendAnEmail(NewEmail email)
        { 
        }
    }

    public class NewEmail:EmailObject
    {
        public NewEmail(string to, string subject, string text, bool attachment = false, Attachment attachmentToAdd = null)
        {
            var gmailMainPage = new GmailMainPage();
            gmailMainPage.PopulateToField(to);
            gmailMainPage.PopulateSubjectField(subject);
            gmailMainPage.PopulateTextField(text);                      
            //attachment == true ? addAttachment(attachmentToAdd) : ;
            if (attachment == true)
            {
                addAttachment(attachmentToAdd);
            }
            this.subject = subject;
            this.creationTime = DateTime.Now;
        }

        public NewEmail addAttachment(Attachment attachment)
        {
            var gmailMainPage = new GmailMainPage();
            gmailMainPage.ClickAddAttachmentButton();
            //to add file
            return this;
        }
    }
}
