using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model.MFD
{
    public class MFDInstrumentMapped
    {
        public int Id { get; set; }
        public int GoalId { get; set; }
        public int PId { get; set; }
        public string InstrumentName { get; set; }
        public double CurrentValue { get; set; }
        public double AdditionalAnnualInv { get; set; }
        public string RealisationYear { get; set; }
        public double ROI { get; set; }
    }
}
