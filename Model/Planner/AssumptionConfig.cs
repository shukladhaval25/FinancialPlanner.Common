using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class AssumptionConfig
    {
        public int PlannerId { get; set; }
        public bool RateOfInflation { get; set; }
        public bool PostTaxRateOfReturn { get; set; }
        public bool RegularOngoingExp { get; set; }
        public bool PostRetirementInvestmentReturn { get; set; }
    }
}
