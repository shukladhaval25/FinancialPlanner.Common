using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class SIPCancellation
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string memberName;
        int amc;
        string folioNumber;
        int schemeId;
        string options;
        double amount;
        DateTime sipStartDate;
        DateTime sipEndDate;
        int sipDate;
        int bankId;
        string accountNo;
        string modeOfExecution;
        string remark;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public int SchemeId { get => schemeId; set => schemeId = value; }
        public string Options { get => options; set => options = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime SipStartDate { get => sipStartDate; set => sipStartDate = value; }
        public DateTime SipEndDate { get => sipEndDate; set => sipEndDate = value; }
        public int SipDate { get => sipDate; set => sipDate = value; }
        public int BankId { get { return bankId; } set { bankId = value; } }
        public string AccountNo { get => accountNo; set => accountNo = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
