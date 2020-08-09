using System;
using System.Collections.Generic;
using System.Text;

namespace BananaSongTest.BusinessObjects
{
    class DraftEmails
    {
        List<EmailObject> listOfDraftEmails = new List<EmailObject>();

        public List<EmailObject> returnTheListOfDraftEmails()
        {

            return listOfDraftEmails;
        }
    }
}
