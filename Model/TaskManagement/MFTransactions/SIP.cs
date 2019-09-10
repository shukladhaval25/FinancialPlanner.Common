using FinancialPlanner.Common.Model.TaskManagement.TaskType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class SIP
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int CID { get; set; }
        public string MemberName { get; set; }
        public string FirstHolder { get; set; }
        public string SecondHolder { get; set; }
        public string ThirdHolder { get; set; }
        public string Nominee { get; set; }
        public string Guardian { get; set; }
        public int SchemeId { get; set; }
        public string FolioNo { get; set; }
        public int AMC { get; set; }
        public string Option { get; set; }
        public double Amount { get; set; }
        public string AccounType { get; set; }
        public int SIPDayOn { get; set; }
        public DateTime SIPStartDate { get; set; }
        public DateTime SIPEndDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ModeOfExecution { get; set; }
        public string Remark {get;set;}
    }
}
