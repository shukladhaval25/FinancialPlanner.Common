using Chilkat;
using System.Collections.Generic;
using System.Data;

namespace FinancialPlanner.Common.EmailManager
{
    public class EmailService
    {
        private bool success;

        public EmailService(string SmtpHost, int SmtPort,string UserName, string pwd, bool isSSL,
            string fromEmail,string impsHost, string impsPort )
        {
            MailServer.HostName = SmtpHost;
            MailServer.HostPort = SmtPort;
            MailServer.UserName = UserName;
            MailServer.Password = pwd;
            MailServer.IsSSL = isSSL;
            MailServer.FromEmail = fromEmail;
            MailServer.POP3_IMPS_HostName = impsHost;
            MailServer.POP3_IMPS_HostPort = impsPort;
            
        }
        public IList<Email> GetAllMails()
        {
            IList<Email> emails = new List<Email>();
            using (Chilkat.Imap imap = new Imap())
            {
                if (imap.UnlockComponent("EASYDAIMAPMAILQ_vcyhVCXs2N0G"))
                {
                    if (connectToIMAPMailServer(imap))
                    {
                        Chilkat.MessageSet messageSet = null;
                        bool fetchUids = false;
                        // Select an IMAP mailbox
                        success = imap.SelectMailbox("Inbox");
                        if (success != true)
                        {
                            //Debug.WriteLine(imap.LastErrorText);
                            return null;
                        }


                        messageSet = imap.Search("FROM eugen@baeldung.com", fetchUids);
                        /*if (success != true)
                        {
                            Logger.LogDebug(imap.LastErrorText);
                            return null;
                        }*/
                        //if (imap.LastMethodSuccess == false)
                        //{
                        //    //Debug.WriteLine(imap.LastErrorText);
                        //    return null;
                        //}

                        //bool bUid = false;
                        //string mimeStr;
                        //int n = imap.NumMessages;

                        Chilkat.EmailBundle bundle = null;
                        bundle = imap.FetchBundle(messageSet);
                        int i = 0;
                        while (i < bundle.MessageCount)
                        {
                            Chilkat.Email email = null;
                            email = bundle.GetEmail(i);
                            emails.Add(email);
                            //DataRow drEmail = dtEmails.NewRow();
                            //drEmail["From"] = email.From;
                            //drEmail["FromAddress"] = email.FromAddress;
                            //drEmail["FromName"] = email.FromName;
                            ////drEmail["To"] = email.;
                            //drEmail["LocalDate"] = email.LocalDate;
                            //drEmail["Subject"] = email.Subject;
                            //drEmail["Body"] = email.Body;
                            //drEmail["NumAttachedMessages"] = email.NumAttachments;
                            //drEmail["Size"] = email.Size;
                            //drEmail["NumDaysOld"] = email.NumDaysOld;
                            //dtEmails.Rows.Add(drEmail);
                            i = i + 1;
                        }


                        // An alternative is to download each email in the form of an
                        // email object, like this:
                        //Chilkat.Email email = null;
                        //for (int i = 1; i <= n; i++)
                        //{

                        //    // Download the email by sequence number.
                        //    email = imap.FetchSingle(i, bUid);                          
                        //    emails.Add(email);
                        //    if (i > 100)
                        //        break;
                        //    // ... your application may process the email object...

                        //}

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

        private static bool connectToIMAPMailServer(Imap imap)
        {
            if (string.IsNullOrEmpty(MailServer.POP3_IMPS_HostName) || 
                string.IsNullOrEmpty(MailServer.UserName) || string.IsNullOrEmpty(MailServer.Password))
            {
                return false;
            }
            imap.AppendSeen = true;
            imap.Port = int.Parse(MailServer.POP3_IMPS_HostPort);
            imap.Ssl = MailServer.IsSSL;
            imap.Connect(MailServer.POP3_IMPS_HostName);
            imap.Login(MailServer.UserName, FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Decrypt(MailServer.Password));
            return imap.IsConnected();
        }

        private static bool connectToSmtpMailServer(Imap imap)
        {
            imap.AppendSeen = true;
            imap.Port = MailServer.HostPort;
            imap.Ssl = MailServer.IsSSL;
            imap.Connect(MailServer.HostName);
            imap.Login(MailServer.UserName,
                FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Decrypt(MailServer.Password));                ;
            return imap.IsConnected();
        }

        private bool isValidMailServerSetting()
        {
            return !string.IsNullOrEmpty(MailServer.HostName) &&
               !string.IsNullOrEmpty(MailServer.HostPort.ToString()) && !string.IsNullOrEmpty(MailServer.Password);
        }
    }    
}
