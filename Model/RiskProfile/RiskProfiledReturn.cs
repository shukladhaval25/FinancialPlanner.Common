using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class RiskProfiledReturn
    {
        int id;
        int _riskProfileId;
        int _yearRemaining;
        decimal _foreingInvestementRatio;
        decimal _equtyInvestementRatio;
        decimal _debtInvestmentRatio;
        decimal _foreingInvestementReaturn;
        decimal _equityInvestementReturn;
        decimal _debtInvestementReturn;
        decimal _averageInvestemetReturn;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int RiskProfileId
        {
            get
            {
                return _riskProfileId;
            }

            set
            {
                _riskProfileId = value;
            }
        }

        public int YearRemaining
        {
            get
            {
                return _yearRemaining;
            }

            set
            {
                _yearRemaining = value;
            }
        }

        public decimal ForeingInvestmentRatio
        {
            get
            {
                return _foreingInvestementRatio;
            }

            set
            {
                _foreingInvestementRatio = value;
            }
        }

        public decimal EquityInvestementRatio
        {
            get
            {
                return _equtyInvestementRatio;
            }

            set
            {
                _equtyInvestementRatio = value;
            }
        }

        public decimal DebtInvestementRatio
        {
            get
            {
                return _debtInvestmentRatio;
            }

            set
            {
                _debtInvestmentRatio = value;
            }
        }

        public decimal ForeingInvestementReaturn
        {
            get
            {
                return _foreingInvestementReaturn;
            }

            set
            {
                _foreingInvestementReaturn = value;
            }
        }

        public decimal EquityInvestementReturn
        {
            get
            {
                return _equityInvestementReturn;
            }

            set
            {
                _equityInvestementReturn = value;
            }
        }

        public decimal DebtInvestementReturn
        {
            get
            {
                return _debtInvestementReturn;
            }

            set
            {
                _debtInvestementReturn = value;
            }
        }

        public decimal AverageInvestemetReturn
        {
            get
            {
                decimal _foreingValue =  (_foreingInvestementRatio * _foreingInvestementReaturn) / 100;
                decimal _equityvalue =  (_equtyInvestementRatio * _equityInvestementReturn) / 100;
                decimal _debtValue =   (_debtInvestmentRatio * _debtInvestementReturn) / 100;

                _averageInvestemetReturn = _foreingValue + _equityvalue + _debtValue;
                return _averageInvestemetReturn;
            }
        }
    }
}
