using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.RiskProfile
{
    public class ModelPortfolio
    {
        public int RiskProfileId { get; set; }
        public string RiskProfileName { get; set; }
        public string InvestmentType { get; set; }
        public string SegmentName { get; set; }
        public float SegmentRatio { get; set; }
        public string SchemeName { get; set; }
    }
}
