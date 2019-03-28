using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class MutualFund : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _schemeName;
        float _nav = 0;
        double _units = 0;
        double _currentValue = 0;
        float _equityRatio;
        float _goldRatio;
        float _debtRatio;
        double _SIP;
        int _freeUnit;
        double _redumptionAmount;
        int? _goalID;
        string _folioNo;
        string _firstHolder;
        string _secondHolder;
        string _nominee;
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

        public string SchemeName
        {
            get
            {
                return _schemeName;
            }

            set
            {
                _schemeName = value;
            }
        }

        public float Nav
        {
            get
            {
                return _nav;
            }

            set
            {
                _nav = value;
            }
        }

        public double Units
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

        public double CurrentValue
        {
            get
            {
                _currentValue = (_nav * _units);
                return _currentValue;
            }           
        }

        public float EquityRatio
        {
            get
            {
                return _equityRatio;
            }

            set
            {
                _equityRatio = value;
            }
        }

        public float GoldRatio
        {
            get
            {
                return _goldRatio;
            }

            set
            {
                _goldRatio = value;
            }
        }

        public float DebtRatio
        {
            get
            {
                return _debtRatio;
            }

            set
            {
                _debtRatio = value;
            }
        }

        public double SIP
        {
            get
            {
                return _SIP;
            }

            set
            {
                _SIP = value;
            }
        }

        public int FreeUnit
        {
            get
            {
                return _freeUnit;
            }

            set
            {
                _freeUnit = value;
            }
        }

        public double RedumptionAmount
        {
            get
            {
                return _redumptionAmount;
            }

            set
            {
                _redumptionAmount = value;
            }
        }

        public int? GoalID
        {
            get
            {
                return _goalID;
            }

            set
            {
                _goalID = value;
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

        public string FolioNo
        {
            get
            {
                return _folioNo;
            }

            set
            {
                _folioNo = value;
            }
        }

        public string FirstHolder
        {
            get
            {
                return _firstHolder;
            }

            set
            {
                _firstHolder = value;
            }
        }

        public string SecondHolder
        {
            get
            {
                return _secondHolder;
            }

            set
            {
                _secondHolder = value;
            }
        }

        public string Nominee
        {
            get
            {
                return _nominee;
            }

            set
            {
                _nominee = value;
            }
        }

        public float InvestmentReturnRate
        {
            get { return _investmentReturnRate; }
            set { _investmentReturnRate = value; }
        }
    }
}
