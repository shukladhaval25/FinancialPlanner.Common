using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.ScoreCalculation
{
    public class ScoreRange
    {
        public int Id { get; set; }
        public int RiskProfileId { get; set; }
        public float FromRange { get; set; }
        public float ToRange { get; set; }
        public float Equity { get; set; }
        public float Debt { get; set; }
        public float Gold { get; set; } 
    }
}
