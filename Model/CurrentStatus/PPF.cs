using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class PPF : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _accountNo;
        string _bank;
        DateTime _openingDate;
        DateTime _maturityDate;
        double _currentValue;
        int? _goalId;
        float _investmentReturnRate;
        bool _isAccountExtended;

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

        public string Bank
        {
            get
            {
                return _bank;
            }

            set
            {
                _bank = value;
            }
        }

        public DateTime OpeningDate
        {
            get
            {
                return _openingDate;
            }

            set
            {
                _openingDate = value;
            }
        }

        public DateTime MaturityDate
        {
            get
            {
                return _maturityDate;
            }

            set
            {
                _maturityDate = value;
            }
        }

        public double CurrentValue
        {
            get
            {
                return _currentValue;
            }

            set
            {
                _currentValue = value;
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

        public bool IsAccountExtended { get => _isAccountExtended; set => _isAccountExtended = value; }
    }
}
