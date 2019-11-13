using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class ChangeOfName : Base
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string fromMemberName;
        string toMemberName;
        int amc;
        string folioNumber;
        bool isSignatureChanged;
        string modeOfExecution;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string FromMemberName { get => fromMemberName; set => fromMemberName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
        public string ToMemberName { get => toMemberName; set => toMemberName = value; }
        public bool IsSignatureChanged { get => isSignatureChanged; set => isSignatureChanged = value; }
    }
}
