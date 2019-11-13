using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class MinorToMajor : Base
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string minorName;
        string guardian;
        int amc;
        string folioNumber;
        string modeOfExecution;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string MinorName { get => minorName; set => minorName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
        public string Guardian { get => guardian; set => guardian = value; }
    }
}
