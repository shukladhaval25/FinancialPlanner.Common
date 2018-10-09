using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public abstract class BankAccount : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _accountNo;
        string _bankName;
        string _branch;
        double _balance;
        float _intRate;
        int? _goalId;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Pid
        {
            get
            {
                return _pid;
            }

            set
            {
                _pid = value;
            }
        }

        public string InvesterName
        {
            get
            {
                return _investerName;
            }

            set
            {
                _investerName = value;
            }
        }

        public string AccountNo
        {
            get
            {
                return _accountNo;
            }

            set
            {
                _accountNo = value;
            }
        }

        public string BankName
        {
            get
            {
                return _bankName;
            }

            set
            {
                _bankName = value;
            }
        }

        public string Branch
        {
            get
            {
                return _branch;
            }

            set
            {
                _branch = value;
            }
        }

        public int? GoalId
        {
            get
            {
                return _goalId;
            }

            set
            {
                _goalId = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public float IntRate
        {
            get
            {
                return _intRate;
            }

            set
            {
                _intRate = value;
            }
        }
    }
}
