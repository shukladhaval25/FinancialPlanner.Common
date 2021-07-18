using Chilkat;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace FinancialPlanner.Common.EmailManager
{
    public class EmailService
    {
        private bool success;
        const SslProtocols _Tls12 = SslProtocols.Tls12; // (SslProtocols)0x00000C00;
        const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
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
        public IList<Email> GetAllMails(string fromEmailID)
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


                        messageSet = imap.Search(string.Format("FROM {0}",fromEmailID) , fetchUids);
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

        public static bool SendEmail(MailMessage mailMessage)
        {
          
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    mailMessage.From = new MailAddress(MailServer.FromEmail);
                    smtp.UseDefaultCredentials = false;
                    smtp.Port = MailServer.HostPort;
                    smtp.Host = MailServer.HostName;
                    //ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    //{
                    //    return true;
                    //};
                    smtp.EnableSsl = (MailServer.IsSSL);
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = 
                        new NetworkCredential(MailServer.UserName, MailServer.Password);
                    smtp.Timeout = 30000;                   
                }

                ServicePointManager.SecurityProtocol = Tls12;
                smtp.Send(mailMessage);
                return true;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static bool SendEmailWithChilkat(MailMessage mailMessage,string attachfilePath)
        {
            //using (Chilkat.Imap imap = new Imap())
            //{
               
                    Chilkat.MailMan mailman = new Chilkat.MailMan();

                    mailman.UnlockComponent("EASYDAIMAPMAILQ_vcyhVCXs2N0G");


                    // Set the SMTP server.
                    mailman.SmtpHost = MailServer.HostName;

                    // Set the SMTP login/password (if required)
                    mailman.SmtpUsername = MailServer.UserName;
                    mailman.SmtpPassword = MailServer.Password;

                    // Connect to SMTP port 465 using TLS.
                    mailman.SmtpSsl = true;
                    mailman.SmtpPort = MailServer.HostPort;

                    // Create a new email object
                    Chilkat.Email email = new Chilkat.Email();

                    email.Subject = mailMessage.Subject;
                    email.From = mailMessage.From.ToString();
                    email.Body = mailMessage.Body;

                    //email.Subject = "This is a test";
                    //email.Body = "This is a test";
                    //email.From = "financialplanning@ascentsolutions.in";
                    bool success = email.AddTo("", mailMessage.To[0].Address.ToString());
                    // To add more recipients, call AddTo, AddCC, or AddBcc once per recipient.

                    // Add some attachments.
                    // The AddFileAttachment method returns the value of the content-type it chose for the attachment.

                    string contentType = email.AddFileAttachment(attachfilePath);

                    //if (email.LastMethodSuccess != true)
                    //{
                    //    Debug.WriteLine(email.LastErrorText);
                    //    return false;
                    //}

                    // Call SendEmail to connect to the SMTP server and send.
                    // The connection (i.e. session) to the SMTP server remains
                    // open so that subsequent SendEmail calls may use the
                    // same connection.  
                    success = mailman.SendEmail(email);
                    if (success != true)
                    {
                        Debug.WriteLine(mailman.LastErrorText);
                        throw new Exception(mailman.LastErrorText);
                    }

                    success = mailman.CloseSmtpConnection();
                    if (success != true)
                    {
                        Debug.WriteLine("Connection to SMTP server not closed cleanly.");
                    }

                    Debug.WriteLine("Mail with attachments sent!");
                    return true;
             //}
            //return true;
        }
    }    
}
