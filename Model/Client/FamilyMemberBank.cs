using FinancialPlanner.Common.Model.Masters;
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
        int bankId;
        string accountNo;
        Bank bank;
        //string branchAddress;
        //string branchContantNo;

        public int Id { get => id; set => id = value; }
        public int BankId { get => bankId; set => bankId = value; }
        public int AccountHolderId { get => accountHolderId; set => accountHolderId = value; }
        public string AccountNo { get => accountNo; set => accountNo = value; }
        public string AccountType { get; set; }
        public Bank Bank { get => bank; set => bank = value; }
        //public string BranchAddress { get => branchAddress; set => branchAddress = value; }
        //public string BranchContantNo { get => branchContantNo; set => branchContantNo = value; }
    }
}
