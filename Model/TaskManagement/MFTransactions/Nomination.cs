using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.TaskManagement.MFTransactions
{
    public class Nomination : Base
    {
        int id;
        int taskId;
        int arn;
        int cid;
        string clientGroup;
        string memberName;
        int amc;
        string folioNumber;
        string nominee1;
        string nominee2;
        double allocationForNominee1;
        double allocationForNominee2;
       
        
        string modeOfExecution;

        public int Id { get => id; set => id = value; }
        public int TaskId { get => taskId; set => taskId = value; }
        public int Arn { get => arn; set => arn = value; }
        public int Cid { get => cid; set => cid = value; }
        public string ClientGroup { get => clientGroup; set => clientGroup = value; }
        public int Amc { get => amc; set => amc = value; }
        public string FolioNumber { get => folioNumber; set => folioNumber = value; }
        public string ModeOfExecution { get => modeOfExecution; set => modeOfExecution = value; }        
        public string MemberName { get => memberName; set => memberName = value; }
        public int Amc1 { get => amc; set => amc = value; }
        public string FolioNumber1 { get => folioNumber; set => folioNumber = value; }
        public string Nominee1 { get => nominee1; set => nominee1 = value; }
        public string Nominee2 { get => nominee2; set => nominee2 = value; }
        public double AllocationForNominee1 { get => allocationForNominee1; set => allocationForNominee1 = value; }
        public double AllocationForNominee2 { get => allocationForNominee2; set => allocationForNominee2 = value; }
    }
}
