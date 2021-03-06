﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class STP
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string memberName;
        int amc;
        string folioNumber;
        int fromSchemeId;
        string fromOptions;
        int schemeId;
        string options;
        double amount;
        int duration;
        String frequency;
        string modeOfExecution;
        string remark;

        public int Id { get => id; set => id = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public int Scheme { get => schemeId; set => schemeId = value; }
        public string Options { get => options; set => options = value; }
        public double Amount { get => amount; set => amount = value; }        
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
        public string Remark { get => remark; set => remark = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int FromSchemeId { get => fromSchemeId; set => fromSchemeId = value; }
        public string FromOptions { get => fromOptions; set => fromOptions = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Frequency { get => frequency; set => frequency = value; }
    }
}
