using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.ScoreCalculation
{
    public class ScoreEntry
    {
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public float Value { get; set; }
    }
}
