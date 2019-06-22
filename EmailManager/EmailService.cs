using Chilkat;
using System.Collections.Generic;

namespace FinancialPlanner.Common.EmailManager
{
    public class EmailService
    {        
        public IList<Email> GetAllMails()
        {
            IList<Email> emails = new List<Email>();
            using (Chilkat.Imap imap = new Imap())
            {
                if (imap.UnlockComponent("EASYDAIMAPMAILQ_vcyhVCXs2N0G"))
                {
                    if (connectToMailServer(imap))
                    {

                        bool success = imap.SelectMailbox("Inbox");
                        if (success != true)
                        {
                            Logger.LogDebug(imap.LastErrorText);
                            return null;
                        }

                        bool bUid = false;
                        string mimeStr;
                        int n = imap.NumMessages;
                       

                        // An alternative is to download each email in the form of an
                        // email object, like this:
                        Chilkat.Email email = null;
                        for (int i = 1; i <= n; i++)
                        {

                            // Download the email by sequence number.
                            email = imap.FetchSingle(i, bUid);                          
                            emails.Add(email);
                            // ... your application may process the email object...

                        }

                        // Disconnect from the IMAP server.
                        success = imap.Disconnect();



                        //bool fetchUids = false;
                        //string fetchEmailCriteria = "ALL";

                        //Chilkat.MessageSet messageSet = new MessageSet();
                        //messageSet = imap.Search(fetchEmailCriteria, fetchUids);
                        //if (messageSet == null)
                        //{
                        //    Logger.LogDebug("Unable to fetch email from mail server.");
                        //    return null;
                        //}

                        //EmailBundle emailBundle = imap.FetchBundle(messageSet);
                        //if (emailBundle == null)
                        //{
                        //    Logger.LogDebug("Unable to fetch email from mail server.");
                        //    return null;
                        //}

                        //for (int i = 0; i <= emailBundle.MessageCount -1;i++)
                        //{
                        //    emailBundle.SortByDate(true);
                        //    Email email = emailBundle.GetEmail(i);
                        //    emails.Add(email);
                        //}                       
                    }
                }
            }
            return emails;         
        }

        private static bool connectToMailServer(Imap imap)
        {
            imap.AppendSeen = true;
            imap.Port = MailServer.HostPort;
            imap.Ssl = MailServer.IsSSL;
            imap.Connect(MailServer.HostName);
            imap.Login(MailServer.UserName, MailServer.Password);
            return imap.IsConnected();
        }

        private bool isValidMailServerSetting()
        {
            return !string.IsNullOrEmpty(MailServer.HostName) &&
               !string.IsNullOrEmpty(MailServer.HostPort.ToString()) && !string.IsNullOrEmpty(MailServer.Password);
        }
    }    
}
