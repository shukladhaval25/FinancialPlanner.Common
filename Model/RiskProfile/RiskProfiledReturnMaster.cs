using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class RiskProfiledReturnMaster : Base
    {
        int _id;
        string _name;
        int _thresholdYear;
        int _maxYear;
        float _preForeingInvestmentRatio;
        float _preEquityInvestmentRatio;
        float _preDebtInvestmentRatio;
        float _postForeingInvestmentRatio;
        float _postEquityInvestmentRatio;
        float _postDebtInvestmentRatio;
        float _foreingInvestmentReturn;
        float _equityInvestmentReturn;
        float _debtInvestmentReturn;

        string _description;
        IList<RiskProfiledReturn> _riskProfileReturn;

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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public IList<RiskProfiledReturn> RiskProfileReturn
        {
            get
            {
                return _riskProfileReturn;
            }

            set
            {
                _riskProfileReturn = value;
            }
        }

        public int ThresholdYear
        {
            get
            {
                return _thresholdYear;
            }

            set
            {
                _thresholdYear = value;
            }
        }

        public int MaxYear
        {
            get
            {
                return _maxYear;
            }

            set
            {
                _maxYear = value;
            }
        }

        public float PreForeingInvestmentRatio
        {
            get
            {
                return _preForeingInvestmentRatio;
            }

            set
            {
                _preForeingInvestmentRatio = value;
            }
        }

        public float PreEquityInvestmentRatio
        {
            get
            {
                return _preEquityInvestmentRatio;
            }

            set
            {
                _preEquityInvestmentRatio = value;
            }
        }

        public float PreDebtInvestmentRatio
        {
            get
            {
                return _preDebtInvestmentRatio;
            }

            set
            {
                _preDebtInvestmentRatio = value;
            }
        }

        public float ForeingInvestmentReturn
        {
            get
            {
                return _foreingInvestmentReturn;
            }

            set
            {
                _foreingInvestmentReturn = value;
            }
        }

        public float EquityInvestmentReturn
        {
            get
            {
                return _equityInvestmentReturn;
            }

            set
            {
                _equityInvestmentReturn = value;
            }
        }

        public float DebtInvestmentReturn
        {
            get
            {
                return _debtInvestmentReturn;
            }

            set
            {
                _debtInvestmentReturn = value;
            }
        }

        public float PostForeingInvestmentRatio
        {
            get
            {
                return _postForeingInvestmentRatio;
            }

            set
            {
                _postForeingInvestmentRatio = value;
            }
        }

        public float PostEquityInvestmentRatio
        {
            get
            {
                return _postEquityInvestmentRatio;
            }

            set
            {
                _postEquityInvestmentRatio = value;
            }
        }

        public float PostDebtInvestmentRatio
        {
            get
            {
                return _postDebtInvestmentRatio;
            }

            set
            {
                _postDebtInvestmentRatio = value;
            }
        }
    }
}
