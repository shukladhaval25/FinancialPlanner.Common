using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.TaskType
{
    public class SIP
    {
        public int Id { get; set; }
        public int ClientGroup { get; set; }
        public int MemberName { get; set; }
        public int FirstHolder { get; set; }
        public int SecondHolder { get; set; }
        public int ThirdHolder { get; set; }
        public int Nominee { get; set; }
        public int Guardian { get; set; }
        public int SchemeId { get; set; }
        public string FolioNo { get; set; }
        public string AMC { get; set; }
        public TransactionOption Option { get; set; }
        public double Amount { get; set; }
        public string AccounType { get; set; }
        public int SIPDayOn { get; set; }
        public DateTime SIPStartDate { get; set; }
        public DateTime SIPEndDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionModeOfExecution ModeOfExecution { get; set; }
    }
}
