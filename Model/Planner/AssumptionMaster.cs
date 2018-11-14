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
        decimal lifeExpectancy;
        decimal preRetirement;
        decimal postRetirement;
        decimal postTaxEquity;
        decimal debtRateOfReturn;
        decimal realEstateRateOfReturn;
        decimal nonFinancialRateOfReturn;
        decimal expenseRaiseRatio;
        decimal insurnceRateOfReturn;
    }
}
