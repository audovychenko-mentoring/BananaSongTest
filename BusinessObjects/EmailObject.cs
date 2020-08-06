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
        public string title;

        public NewEmail CreateNewEmail(string title)
        {
            return new NewEmail(title);
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
        public NewEmail(string title, bool attachment = false, Attachment attachmentToAdd = null)
        {
            this.title = title;
            this.creationTime = DateTime.Now;
            //attachment == true ? addAttachment(attachmentToAdd) : ;
            if (attachment == true)
            {
                addAttachment(attachmentToAdd);
            }
        }

        public NewEmail addAttachment(Attachment attachment)
        { 
            return this;
        }
    }
}
