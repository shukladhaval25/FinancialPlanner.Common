using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.ScoreCalculation
{
    public class Score
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float MaxValue { get; set; }
        public float MinValue { get; set; }
        public float Weightage { get; set; }
    }
}
