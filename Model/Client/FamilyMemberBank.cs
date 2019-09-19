using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class FamilyMemberBank :Base
    {
        int id;
        int accountHolderId;
        string bankName;
        string accountNo;
        string accountType;
        string branchAddress;
        string branchContantNo;

        public int Id { get => id; set => id = value; }
        public int AccountHolderId { get => accountHolderId; set => accountHolderId = value; }
        public string BankName { get => bankName; set => bankName = value; }
        public string AccountNo { get => accountNo; set => accountNo = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public string BranchAddress { get => branchAddress; set => branchAddress = value; }
        public string BranchContantNo { get => branchContantNo; set => branchContantNo = value; }
    }
}
