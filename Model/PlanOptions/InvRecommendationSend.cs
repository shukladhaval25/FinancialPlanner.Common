using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.PlanOptions
{
    public class InvRecommendationSend
    {
        int id;
        int pid;
        int clientId;
        DateTime sendDate;
        string reportDataPath;
        string fileName;

        public int Id { get => id; set => id = value; }
        public int Pid { get => pid; set => pid = value; }
        public DateTime SendDate { get => sendDate; set => sendDate = value; }
        public string ReportDataPath { get => reportDataPath; set => reportDataPath = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public int ClientId { get => clientId; set => clientId = value; }
    }
}
