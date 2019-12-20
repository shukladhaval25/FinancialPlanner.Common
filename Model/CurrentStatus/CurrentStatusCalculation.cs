using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.CurrentStatus
{
    public class CurrentStatusCalculation
    {
        int _pid;
        //List<Tuple<string, double, float>> _currestStatusInstruments;
        double _shresValue;
        double _equityMFvalue;
        double _npsEquityValue;
        double _otherEquityValue;

        double _fdValue;
        double _rdValue;
        double _saValue;
        double _debtMFValue;
        double _npsDebtValue;
        double _PPFValue;
        double _EPFValue;
        double _others;
        double _SSValue;
        double _SCSSValue;
        double _nscValue;
        double _bondsValue;
        double _otherDebtValue;

        double _goldValue;
        double _othersGoldValue;
        bool _isGoalMapDataExcluded = true;

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

        public double ShresValue
        {
            get
            {
                return _shresValue;
            }

            set
            {
                _shresValue = value;
            }
        }

        public double EquityMFvalue
        {
            get
            {
                return _equityMFvalue;
            }

            set
            {
                _equityMFvalue = value;
            }
        }

        public double NpsEquityValue
        {
            get
            {
                return _npsEquityValue;
            }

            set
            {
                _npsEquityValue = value;
            }
        }

        public double OtherEquityValue
        {
            get
            {
                return _otherEquityValue;
            }

            set
            {
                _otherEquityValue = value;
            }
        }

        public double FdValue
        {
            get
            {
                return _fdValue;
            }

            set
            {
                _fdValue = value;
            }
        }

        public double RdValue
        {
            get
            {
                return _rdValue;
            }

            set
            {
                _rdValue = value;
            }
        }

        public double SaValue
        {
            get
            {
                return _saValue;
            }

            set
            {
                _saValue = value;
            }
        }

        public double NpsDebtValue
        {
            get
            {
                return _npsDebtValue;
            }

            set
            {
                _npsDebtValue = value;
            }
        }

        public double PPFValue
        {
            get
            {
                return _PPFValue;
            }

            set
            {
                _PPFValue = value;
            }
        }

        public double EPFValue
        {
            get
            {
                return _EPFValue;
            }

            set
            {
                _EPFValue = value;
            }
        }

        public double SSValue
        {
            get
            {
                return _SSValue;
            }

            set
            {
                _SSValue = value;
            }
        }

        public double SCSSValue
        {
            get
            {
                return _SCSSValue;
            }

            set
            {
                _SCSSValue = value;
            }
        }

        public double NscValue
        {
            get
            {
                return _nscValue;
            }

            set
            {
                _nscValue = value;
            }
        }

        public double BondsValue
        {
            get
            {
                return _bondsValue;
            }

            set
            {
                _bondsValue = value;
            }
        }

        public double OtherDebtValue
        {
            get
            {
                return _otherDebtValue;
            }

            set
            {
                _otherDebtValue = value;
            }
        }

        public double GoldValue
        {
            get
            {
                return _goldValue;
            }

            set
            {
                _goldValue = value;
            }
        }

        public double OthersGoldValue
        {
            get
            {
                return _othersGoldValue;
            }

            set
            {
                _othersGoldValue = value;
            }
        }

        public bool IsGoalMapDataExcluded
        {
            get
            {
                return _isGoalMapDataExcluded;
            }

            set
            {
                _isGoalMapDataExcluded = value;
            }
        }

        public double DebtMFValue
        {
            get
            {
                return _debtMFValue;
            }

            set
            {
                _debtMFValue = value;
            }
        }

        public double Others { get => _others; set => _others = value; }
        public double Total
        {
            get
            {
                return _shresValue + _equityMFvalue + _npsEquityValue + _otherEquityValue + _fdValue + _rdValue + _saValue + _debtMFValue + _npsDebtValue + _PPFValue + _EPFValue + _others + _SSValue + _SCSSValue + _nscValue + _bondsValue + _otherDebtValue + _goldValue + _othersGoldValue;
            }
        }
    }
}