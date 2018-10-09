using System;
using System.Net.Mail;

namespace FinancialPlanner.Common.Model
{
    public class Email : Base
    {
        private string _smtpServerHost;
        private int _smptPort;
        private string _fromEmail;
        private string _userName;
        private string _password;
        private bool _isSSL;

        public string SMTPServerHost
        {
            get { return _smtpServerHost; }
            set { _smtpServerHost = value; }
        }

        public int SMTPPort
        {
            get { return _smptPort; }
            set { _smptPort = value; }
        }

        public string FromEmail
        {
            get { return _fromEmail; }
            set { _fromEmail = value; }
        }

        public string UserName
        { 
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool IsSSL
        {
            get { return _isSSL; }
            set { _isSSL = value; }
        }

        public void SendEmail(MailMessage mailMsg)
        {          
            try
            {
                MailMessage mail = mailMsg;
                SmtpClient SmtpServer = new SmtpClient(_smtpServerHost);

                mail.From = new MailAddress(_fromEmail);
              
                SmtpServer.Port = _smptPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_userName, _password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Logger.LogDebug(ex.ToString());
                throw ex;
            }
        }
    }
}
