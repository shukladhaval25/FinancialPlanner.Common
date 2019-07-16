using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class AssumptionMaster : Base
    {
        int id;
        int retirementAge;
        int lifeExpectancy;
        decimal _preRetirementInflactionRate;
        decimal _postRetirementInflactionRate;
        decimal _equityReturnRate;
        decimal _debtReturnRate;
        decimal _otherReturnRate;
        decimal _incomeRaiseRatio;
        decimal _ongoingExpRise;
        decimal _nonFinancialRateOfReturn;
        decimal _postRetirementInvestmentReturnRate;
       
        

        public int Id { get => id; set => id = value; }
        public int RetirementAge { get => retirementAge; set => retirementAge = value; }
        public int LifeExpectancy { get => lifeExpectancy; set => lifeExpectancy = value; }
        public decimal PreRetirementInflactionRate { get => _preRetirementInflactionRate; set => _preRetirementInflactionRate = value; }
        public decimal PostRetirementInflactionRate { get => _postRetirementInflactionRate; set => _postRetirementInflactionRate = value; }
        public decimal EquityReturnRate { get => _equityReturnRate; set => _equityReturnRate = value; }
        public decimal DebtReturnRate { get => _debtReturnRate; set => _debtReturnRate = value; }
        public decimal OtherReturnRate { get => _otherReturnRate; set => _otherReturnRate = value; }
        public decimal NonFinancialRateOfReturn { get => _nonFinancialRateOfReturn; set => _nonFinancialRateOfReturn = value; }
        public decimal OngoingExpRise { get => _ongoingExpRise; set => _ongoingExpRise = value; }
        public decimal IncomeRaiseRatio { get => _incomeRaiseRatio; set => _incomeRaiseRatio = value; }
        public decimal PostRetirementInvestmentReturnRate { get => _postRetirementInvestmentReturnRate; set => _postRetirementInvestmentReturnRate = value; }
    }
}
