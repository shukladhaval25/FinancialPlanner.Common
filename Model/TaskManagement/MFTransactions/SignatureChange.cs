using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class SignatureChange
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string folioNumber;
        string memberName;
        int amc;
        string firstHolder;
        string secondHolder;
        string thirdHolder;
        string modeOfExecution;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public string FirstHolder { get => firstHolder; set => firstHolder = value; }
        public string SecondHolder { get => secondHolder; set => secondHolder = value; }
        public string ThirdHolder { get => thirdHolder; set => thirdHolder  = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
    }
}
