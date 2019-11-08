using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class AddressChange
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string folioNumber;
        string memberName;
        int amc;
        string address;        
        string modeOfExecution;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public string Address { get => address; set => address = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }
    }
}
