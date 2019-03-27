using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class NPS : Base
    {
        int _id;
        int _pid;
        string _investerName;
        string _schemeName;
        float _nav = 0;
        int _units = 0;
        double _currentValue = 0;
        float _equityRatio;
        float _goldRatio;
        float _debtRatio;
        double _SIP;
        int? _goalID;
        string _folioNo;
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

        public float InvestmentReturnRate { get => _investmentReturnRate; set => _investmentReturnRate = value; }
    }
}
