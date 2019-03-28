using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class NSC : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _postOfficeBranch;
        string _documentNo;
        float _rate;
        DateTime _maturityDate;
        int _units;
        float _valueOfOne;
        double _currentValue;
        int? _goalId;
        float _investmentReturnRate;

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

        public string PostOfficeBranch
        {
            get
            {
                return _postOfficeBranch;
            }

            set
            {
                _postOfficeBranch = value;
            }
        }

        public string DocumentNo
        {
            get
            {
                return _documentNo;
            }

            set
            {
                _documentNo = value;
            }
        }

        public float Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                _rate = value;
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

        public int Units
        {
            get
            {
                return _units;
            }

            set
            {
                _units = value;
            }
        }

        public float ValueOfOne
        {
            get
            {
                return _valueOfOne;
            }

            set
            {
                _valueOfOne = value;
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
    }
}
