using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class EPF : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _accountNo;
        string _particular;
        double _amount;
        int? _goalId;
        float _investmentReturnRate =0;

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

        public string Particular
        {
            get
            {
                return _particular;
            }

            set
            {
                _particular = value;
            }
        }

        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
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

        public float InvestmentReturnRate
        {
            get
            {
                return _investmentReturnRate;
            }

            set
            {
                _investmentReturnRate = value;
            }
        }
    }
}
