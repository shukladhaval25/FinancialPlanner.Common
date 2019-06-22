using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.EmailManager
{
    public static class MailServer
    {
        public static string HostName { get; set; }
        public static int HostPort { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static bool IsSSL { get; set; }
        public static string FromEmail { get; set; }
        public static string POP3_IMPS_HostName { get; set; }
        public static string POP3_IMPS_HostPort { get; set; }
    }
}
